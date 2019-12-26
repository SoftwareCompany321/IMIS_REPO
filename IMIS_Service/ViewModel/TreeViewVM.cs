using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class TreeViewVM
    {
        public string id { get; set; }

        public string text { get; set; }
        public string parentId { get; set; }
        public List<TreeViewVM> children { get; set; }
        public bool opened { get; set; } = false;
    }
    public class TreeViewContainer
    {
        public string parentId { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public object children { get; set; }
        public bool opened { get; set; } = false;
        public object a_attr { get; set; }
        public object state { get; set; }
        public TreeViewContainer AddChildrens(List<TreeViewVM> srcdata, int level)
        {
           
            if (level == 2) children = true;  
            if (level < 2)
            {
                level++;
                children = (from d in srcdata
                            where d.parentId == id
                            select
                            (new TreeViewContainer()
                            {
                                text = d.text,
                                id = d.id,
                                parentId = null,
                                state = new { d.opened },
                                opened = d.opened,
                                a_attr = new { href = "#",onclick= "loadchildlist('" + d.id + "');",  }
                            }).AddChildrens(srcdata, level));
            }
            return this;
        }
    }
}
