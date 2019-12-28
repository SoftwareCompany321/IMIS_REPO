using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class BudjetSource
    {
        public BudjetSource()
        {
            AccBudjetSource = new HashSet<AccBudjetSource>();
            PisEmpDepSource = new HashSet<PisEmpDepSource>();
            SubModuleSource = new HashSet<SubModuleSource>();
        }

        public int Id { get; set; } 
        public int? ParentId { get; set; }
        public int? CountryId { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<AccBudjetSource> AccBudjetSource { get; set; }
        public virtual ICollection<PisEmpDepSource> PisEmpDepSource { get; set; }
        public virtual ICollection<SubModuleSource> SubModuleSource { get; set; }
    }
}
