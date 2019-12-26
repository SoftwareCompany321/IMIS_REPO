using IMIS_Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IMIS.TreeView
{
    public interface IObjectRepositary
    {
        string openedid { get; set; }
        string closedid { get; set; }
        List<TreeViewVM> Datas { get; set; }
        List<TreeViewContainer> GetDataTree(string parentId, string[] openedNodes);
    }

    // Поствщик данных
    public class ObjectRepositary : IObjectRepositary
    {
        public List<TreeViewVM> Datas { get; set; }
        public string openedid { get; set; }
        public string closedid { get; set; }
        public ObjectRepositary()
        {
            Datas = Getdatas();
        }
        // Формирование плоского списка узлов. Только для примера.
        // Flat List of nodes. Only for example
        private List<TreeViewVM> Getdatas()
        {
            List<TreeViewVM> Datas = new List<TreeViewVM>();
            //var response = await _ItemCategory.ItemCategoriesFetchData(model);
            return Datas;
        }
        

        // Формирование дерева для jstree
        // building tree for jstree
        public List<TreeViewContainer> GetDataTree(string id, string[] openedNodes)
        {
            
            List<TreeViewContainer> result = new List<TreeViewContainer>();
            result = (from d in Datas
                      where d.parentId == id
                      select (new TreeViewContainer()
                      {
                          text = d.text,
                          id = d.id,
                          parentId = null,
                          state = new { d.opened },
                          opened = d.opened,
                          a_attr = new { href = "/Test2", }
                      }).AddChildrens(Datas, 0)).ToList();
            return result;
        }
    }


    public class TreeViewPathProvider
    {
        private string openNodesString = string.Empty;
        private Regex rg = new Regex(@"<{1}(?<node>[^/>]+)>{1}", RegexOptions.Compiled);
        public string[] openedNodes { get; set; }

        private static TreeViewPathProvider tvpp;
        private TreeViewPathProvider()
        { }
        public static TreeViewPathProvider Instance()
        {
            if (tvpp == null) tvpp = new TreeViewPathProvider();
            return tvpp;
        }


        public string OpenNodesString
        {
            get { return openNodesString; }
            set
            {
                openNodesString = value;
                // формируем массив id открытых узлов
                // making array of id`s of opened nodes
                openedNodes = (from m in rg.Matches(OpenNodesString) select m.Groups["node"].Value).ToArray();
            }
        }
        public TreeViewPathProvider AddNode(string parentId, string id)
        {
            // # -- виртуальный корень леса. 
            // # -- virtual node of forest
            if (parentId == "#") // при разворачивании корня дерева (у него parentId == "#") забываем всю историю и начинаем новую
            {
                OpenNodesString = $"<{id}></{id}>";
            }
            else
            {
                // вставляем id открываемого узла.
                // insert id of new jpening node
                int start = OpenNodesString.IndexOf($"<{parentId}>") + $"<{parentId}>".Length;
                OpenNodesString = OpenNodesString.Insert(start, $"<{id}></{id}>");
            }
            return this;
        }
        public TreeViewPathProvider DelNode(string id)
        {
            // При закрытии узла удаляем его вместе со всем содержимым из OpenNodesString
            // Delen node with all him content
            Regex rgr = new Regex($@"<{id}>.*</{id}>");
            OpenNodesString = rgr.Replace(OpenNodesString, "");
            return this;
        }
    }
}
