using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisNijamatiSewaSamuha
    {
        public PisNijamatiSewaSamuha()
        {
            InverseParent = new HashSet<PisNijamatiSewaSamuha>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int order { get; set; }
        public int? GrpLevel { get; set; }

        public virtual PisNijamatiSewaSamuha Parent { get; set; }
        public virtual ICollection<PisNijamatiSewaSamuha> InverseParent { get; set; }
    }
}
