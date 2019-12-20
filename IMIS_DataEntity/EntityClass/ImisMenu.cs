using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMIS_DataEntity.EntityClass
{
    public partial class ImisMenu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] 
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string DisplayName { get; set; }
        public int ParentMenuId { get; set; }
        public bool Active { get; set; }
        public bool IsLocked { get; set; }
        public bool Visible { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
        public string DisplayNepName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
  
    }
}
