using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_CORE.Utility
{
    // this is the property of datatable for the jquery while binding for the font end getting the value
    public class DataTableVm
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public string search { get; set; }
        public int filter { get; set; }
        public string status { get; set; }
    }

    public class Column
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
    }
}
