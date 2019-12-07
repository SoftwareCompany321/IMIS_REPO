using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisLocalPostMaster
    {
        public PisLocalPostMaster()
        {
            PisAwards = new HashSet<PisAwards>();
            PisDarbandi = new HashSet<PisDarbandi>();
            PisEmpLongLeaves = new HashSet<PisEmpLongLeaves>();
            PisEmpMedExpense = new HashSet<PisEmpMedExpense>();
            PisEmpPunishmnts = new HashSet<PisEmpPunishmnts>();
            PisEmpSrvcDtls = new HashSet<PisEmpSrvcDtls>();
            PisEmpSuspends = new HashSet<PisEmpSuspends>();
            PisEmpTrnsfrRec = new HashSet<PisEmpTrnsfrRec>();
            PisEmployeeMaster = new HashSet<PisEmployeeMaster>();
            PisForeignVisits = new HashSet<PisForeignVisits>();
            PisFulfilledDarbandi = new HashSet<PisFulfilledDarbandi>();
            PisInternalTransfer = new HashSet<PisInternalTransfer>();
            PisOtherAddSub = new HashSet<PisOtherAddSub>();
            PisPrizes = new HashSet<PisPrizes>();
            PisPublication = new HashSet<PisPublication>();
            PisSgnfcntWork = new HashSet<PisSgnfcntWork>();
            PisTraining = new HashSet<PisTraining>();
            PisWorkshop = new HashSet<PisWorkshop>();
        }

        public decimal LocalPostId { get; set; }
        public string LocalPostName { get; set; }
        public string LocalPostNameEn { get; set; }
        public decimal? PostId { get; set; }
        public string PostDuties { get; set; }
        public double? BasicSalary { get; set; }
        public double? GradeRate { get; set; }
        public double? Allwance { get; set; }
        public double? InsuranceAddAmt { get; set; }
        public decimal? PayrollOrder { get; set; }
        public double? Alllwance { get; set; }
        public double? Allowance { get; set; }

        public virtual PisPostMaster Post { get; set; }
        public virtual ICollection<PisAwards> PisAwards { get; set; }
        public virtual ICollection<PisDarbandi> PisDarbandi { get; set; }
        public virtual ICollection<PisEmpLongLeaves> PisEmpLongLeaves { get; set; }
        public virtual ICollection<PisEmpMedExpense> PisEmpMedExpense { get; set; }
        public virtual ICollection<PisEmpPunishmnts> PisEmpPunishmnts { get; set; }
        public virtual ICollection<PisEmpSrvcDtls> PisEmpSrvcDtls { get; set; }
        public virtual ICollection<PisEmpSuspends> PisEmpSuspends { get; set; }
        public virtual ICollection<PisEmpTrnsfrRec> PisEmpTrnsfrRec { get; set; }
        public virtual ICollection<PisEmployeeMaster> PisEmployeeMaster { get; set; }
        public virtual ICollection<PisForeignVisits> PisForeignVisits { get; set; }
        public virtual ICollection<PisFulfilledDarbandi> PisFulfilledDarbandi { get; set; }
        public virtual ICollection<PisInternalTransfer> PisInternalTransfer { get; set; }
        public virtual ICollection<PisOtherAddSub> PisOtherAddSub { get; set; }
        public virtual ICollection<PisPrizes> PisPrizes { get; set; }
        public virtual ICollection<PisPublication> PisPublication { get; set; }
        public virtual ICollection<PisSgnfcntWork> PisSgnfcntWork { get; set; }
        public virtual ICollection<PisTraining> PisTraining { get; set; }
        public virtual ICollection<PisWorkshop> PisWorkshop { get; set; }
    }
}
