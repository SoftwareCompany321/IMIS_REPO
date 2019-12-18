using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //this is for the auto increment primary key using the interger value
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string NepName { get; set; }
        [Column(TypeName = "varchar(100)")] 
        public string NepEng { get; set; }
        [Column(TypeName = "varchar(100)")] 
        public string Remarks { get; set; }
        [Column(TypeName = "char(1)")] 
        public string Isdefault { get; set; }
    }
}
