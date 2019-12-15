using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IMIS_DataEntity.EntityClass
{
    public partial class ImisMenu
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //this is for the auto increment primary key using the interger value
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string MenuName { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string MenuUrl { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string DisplayName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string DisplayNepName { get; set; }
        public int ParentMenuId { get; set; }
        public bool Active { get; set; }
        public bool IsLocked { get; set; }
        public bool Visible { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Icon { get; set; }
        public int MenuOrder { get; set; }

        [Column(TypeName = "varchar(450)")]
        public string CreatedBy { get; set; } 
        [Column(TypeName = "varchar(450)")]
        public string UpdateBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
