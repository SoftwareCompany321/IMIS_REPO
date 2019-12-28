using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurType
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NepName { get; set; }
        public string NepEng { get; set; }
        public string Remarks { get; set; }
        public char? Isdefault { get; set; }
    }
}
