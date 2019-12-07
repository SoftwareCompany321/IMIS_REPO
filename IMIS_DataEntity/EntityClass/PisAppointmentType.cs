using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisAppointmentType
    {
        public PisAppointmentType()
        {
            PisInternalTransferAppointmntTypeNavigation = new HashSet<PisInternalTransfer>();
            PisInternalTransferToAppointmntTypeNavigation = new HashSet<PisInternalTransfer>();
        }

        public decimal Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PisInternalTransfer> PisInternalTransferAppointmntTypeNavigation { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransferToAppointmntTypeNavigation { get; set; }
    }
}
