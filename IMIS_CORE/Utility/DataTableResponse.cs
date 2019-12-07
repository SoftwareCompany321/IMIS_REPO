using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_CORE.Utility
{
    public sealed class DataTableResponse
    {
        public int draw { get; set; }
        public int TotalRecord { get; set; }
        public int FilteredRecord { get; set; }
        public object data { get; set; }
    }
}
