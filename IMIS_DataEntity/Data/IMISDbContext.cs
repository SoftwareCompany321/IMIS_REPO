using IMIS_DataEntity.EntityClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace IMIS_DataEntity.Data
{
    public partial class IMISDbContext : IdentityDbContext<Usermaster>
    {

        public IMISDbContext(DbContextOptions<IMISDbContext> options) : base(options)
        {

        }

        public virtual DbSet<AccAccMaster> AccAccMaster { get; set; }
        public virtual DbSet<AccAsuliBibaran> AccAsuliBibaran { get; set; }
        public virtual DbSet<AccBankGrnty> AccBankGrnty { get; set; }
        public virtual DbSet<AccBankStatement> AccBankStatement { get; set; }
        public virtual DbSet<AccBankTrans> AccBankTrans { get; set; }
        public virtual DbSet<AccBgtAllocate> AccBgtAllocate { get; set; }
        public virtual DbSet<AccBgtRvsn> AccBgtRvsn { get; set; }
        public virtual DbSet<AccBgtTransfer> AccBgtTransfer { get; set; }
        public virtual DbSet<AccBudjetSource> AccBudjetSource { get; set; }
        public virtual DbSet<AccCashTrans> AccCashTrans { get; set; }
        public virtual DbSet<AccChequeTypes> AccChequeTypes { get; set; }
        public virtual DbSet<AccCurrencty> AccCurrencty { get; set; }
        public virtual DbSet<AccCurrenctyRate> AccCurrenctyRate { get; set; }
        public virtual DbSet<AccDhrtiBillDtl> AccDhrtiBillDtl { get; set; }
        public virtual DbSet<AccDhrtiBillMaster> AccDhrtiBillMaster { get; set; }
        public virtual DbSet<AccExpensesDetails> AccExpensesDetails { get; set; }
        public virtual DbSet<AccFundProvidrMstr> AccFundProvidrMstr { get; set; }
        public virtual DbSet<AccIncomeRate> AccIncomeRate { get; set; }
        public virtual DbSet<AccLastYrPeski> AccLastYrPeski { get; set; }
        public virtual DbSet<AccLastyearAdvDetails> AccLastyearAdvDetails { get; set; }
        public virtual DbSet<AccOrgMaster> AccOrgMaster { get; set; }
        public virtual DbSet<AccPadadhikariMstr> AccPadadhikariMstr { get; set; }
        public virtual DbSet<AccPadadhikariPost> AccPadadhikariPost { get; set; }
        public virtual DbSet<AccPaymentClearance> AccPaymentClearance { get; set; }
        public virtual DbSet<AccPaymentCredit> AccPaymentCredit { get; set; }
        public virtual DbSet<AccPaymentDeduction> AccPaymentDeduction { get; set; }
        public virtual DbSet<AccPaymentDetails> AccPaymentDetails { get; set; }
        public virtual DbSet<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual DbSet<AccReceivable> AccReceivable { get; set; }
        public virtual DbSet<AccSubModuleType> AccSubModuleType { get; set; }
        public virtual DbSet<AccTransType> AccTransType { get; set; }
        public virtual DbSet<AccUnauthorised> AccUnauthorised { get; set; }
        public virtual DbSet<AccUserComiteMstr> AccUserComiteMstr { get; set; }
        public virtual DbSet<AccVchrDetails> AccVchrDetails { get; set; }
        public virtual DbSet<AccVchrMaster> AccVchrMaster { get; set; }
        public virtual DbSet<AccVchrTypeMaster> AccVchrTypeMaster { get; set; }
        public virtual DbSet<AccWorkFundsDetail> AccWorkFundsDetail { get; set; }
        public virtual DbSet<AccWorkMaster> AccWorkMaster { get; set; }
        public virtual DbSet<AccWorkPaymntTrans> AccWorkPaymntTrans { get; set; }
        public virtual DbSet<Accode> Accode { get; set; }
        public virtual DbSet<ApplicationConfiguration> ApplicationConfiguration { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<Bankmaster> Bankmaster { get; set; }
        public virtual DbSet<Banktransactions> Banktransactions { get; set; }
        public virtual DbSet<BudjetSource> BudjetSource { get; set; }
        public virtual DbSet<BudjetSubHead> BudjetSubHead { get; set; }
        public virtual DbSet<BusinessmasterHistory> BusinessmasterHistory { get; set; }
        public virtual DbSet<Cashtransaction> Cashtransaction { get; set; }
        public virtual DbSet<Celedger20682069> Celedger20682069 { get; set; }
        public virtual DbSet<Collectioncounters> Collectioncounters { get; set; }
        public virtual DbSet<Constantvalues> Constantvalues { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Ddc> Ddc { get; set; }
        public virtual DbSet<DevRegion> DevRegion { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<EmpGrp> EmpGrp { get; set; }
        public virtual DbSet<Firebrigadestate> Firebrigadestate { get; set; }
        public virtual DbSet<Fiscalyears> Fiscalyears { get; set; }
        public virtual DbSet<Fywiserentdarrate> Fywiserentdarrate { get; set; }
        public virtual DbSet<FywisesanitationRate> FywisesanitationRate { get; set; }
        public virtual DbSet<ImisMenu> ImisMenu { get; set; }
        public virtual DbSet<Incomebilldetails> Incomebilldetails { get; set; }
        public virtual DbSet<IncomebilldetailsHistory> IncomebilldetailsHistory { get; set; }
        public virtual DbSet<Incomebillmaster> Incomebillmaster { get; set; }
        public virtual DbSet<InvApplicantRate> InvApplicantRate { get; set; }
        public virtual DbSet<InvBrand> InvBrand { get; set; }
        public virtual DbSet<InvDeplist> InvDeplist { get; set; }
        public virtual DbSet<InvDepreciation> InvDepreciation { get; set; }
        public virtual DbSet<InvDept> InvDept { get; set; }
        public virtual DbSet<InvGoodsAdjust> InvGoodsAdjust { get; set; }
        public virtual DbSet<InvGoodsRecDetl> InvGoodsRecDetl { get; set; }
        public virtual DbSet<InvGoodsRecMast> InvGoodsRecMast { get; set; }
        public virtual DbSet<InvIncreaseDecrease> InvIncreaseDecrease { get; set; }
        public virtual DbSet<InvIssueDakhila> InvIssueDakhila { get; set; }
        public virtual DbSet<InvIssueDetail> InvIssueDetail { get; set; }
        public virtual DbSet<InvIssueMaster> InvIssueMaster { get; set; }
        public virtual DbSet<InvItemAdjType> InvItemAdjType { get; set; }
        public virtual DbSet<InvItemCategory> InvItemCategory { get; set; }
        public virtual DbSet<InvItemDetails> InvItemDetails { get; set; }
        public virtual DbSet<InvItemMst> InvItemMst { get; set; }
        public virtual DbSet<InvItemSpec> InvItemSpec { get; set; }
        public virtual DbSet<InvItemStatuscheck> InvItemStatuscheck { get; set; }
        public virtual DbSet<InvLilamAppmaster> InvLilamAppmaster { get; set; }
        public virtual DbSet<InvLilamDetail> InvLilamDetail { get; set; }
        public virtual DbSet<InvLilamMast> InvLilamMast { get; set; }
        public virtual DbSet<InvLilamRecList> InvLilamRecList { get; set; }
        public virtual DbSet<InvLilamappdetails> InvLilamappdetails { get; set; }
        public virtual DbSet<InvOrgType> InvOrgType { get; set; }
        public virtual DbSet<InvProject> InvProject { get; set; }
        public virtual DbSet<InvPurMastPlan> InvPurMastPlan { get; set; }
        public virtual DbSet<InvPurOrderDetl> InvPurOrderDetl { get; set; }
        public virtual DbSet<InvPurOrderMast> InvPurOrderMast { get; set; }
        public virtual DbSet<InvPurType> InvPurType { get; set; }
        public virtual DbSet<InvReqDetail> InvReqDetail { get; set; }
        public virtual DbSet<InvRequisitionMast> InvRequisitionMast { get; set; }
        public virtual DbSet<InvRoomMst> InvRoomMst { get; set; }
        public virtual DbSet<InvStatusDetail> InvStatusDetail { get; set; }
        public virtual DbSet<InvSupItmDet> InvSupItmDet { get; set; }
        public virtual DbSet<InvSupplier> InvSupplier { get; set; }
        public virtual DbSet<InvSupplierFiscalyear> InvSupplierFiscalyear { get; set; }
        public virtual DbSet<InvTaxRate> InvTaxRate { get; set; }
        public virtual DbSet<InvTypeSetup> InvTypeSetup { get; set; }
        public virtual DbSet<InvUnit> InvUnit { get; set; }
        public virtual DbSet<InvWarehouse> InvWarehouse { get; set; }
        public virtual DbSet<InvYrlyPurPlan> InvYrlyPurPlan { get; set; }
        public virtual DbSet<IpttaxsummaryHistory> IpttaxsummaryHistory { get; set; }
        public virtual DbSet<Issuedbills> Issuedbills { get; set; }
        public virtual DbSet<Landmeasuringunits> Landmeasuringunits { get; set; }
        public virtual DbSet<Landsmultievaluationdetail> Landsmultievaluationdetail { get; set; }
        public virtual DbSet<Leledger20682069> Leledger20682069 { get; set; }
        public virtual DbSet<MalpotLands> MalpotLands { get; set; }
        public virtual DbSet<MapAreaGndCov> MapAreaGndCov { get; set; }
        public virtual DbSet<MapConstrctionKind> MapConstrctionKind { get; set; }
        public virtual DbSet<MapDesignerDtl> MapDesignerDtl { get; set; }
        public virtual DbSet<MapDirection> MapDirection { get; set; }
        public virtual DbSet<MapDrainType> MapDrainType { get; set; }
        public virtual DbSet<MapFloor> MapFloor { get; set; }
        public virtual DbSet<MapHouseuseType> MapHouseuseType { get; set; }
        public virtual DbSet<MapHtstandard> MapHtstandard { get; set; }
        public virtual DbSet<MapIncomeType> MapIncomeType { get; set; }
        public virtual DbSet<MapLandOwnerType> MapLandOwnerType { get; set; }
        public virtual DbSet<MapNeighbourType> MapNeighbourType { get; set; }
        public virtual DbSet<MapRate> MapRate { get; set; }
        public virtual DbSet<MapRegionFar> MapRegionFar { get; set; }
        public virtual DbSet<MapRoofCnstrctType> MapRoofCnstrctType { get; set; }
        public virtual DbSet<MapRoofType> MapRoofType { get; set; }
        public virtual DbSet<MapSite> MapSite { get; set; }
        public virtual DbSet<MapStdheightRw> MapStdheightRw { get; set; }
        public virtual DbSet<MapStoreys> MapStoreys { get; set; }
        public virtual DbSet<MapStructureType> MapStructureType { get; set; }
        public virtual DbSet<MapZone> MapZone { get; set; }
        public virtual DbSet<Ministry> Ministry { get; set; }
        public virtual DbSet<MinistryAccHead> MinistryAccHead { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<NewPropertyTaxtable> NewPropertyTaxtable { get; set; }
        public virtual DbSet<OfficeType> OfficeType { get; set; }
        public virtual DbSet<OrgBankAccount> OrgBankAccount { get; set; }
        public virtual DbSet<OrganizationTree> OrganizationTree { get; set; }
        public virtual DbSet<PaymentSlipMaster> PaymentSlipMaster { get; set; }
        public virtual DbSet<PersonTypeMaster> PersonTypeMaster { get; set; }
        public virtual DbSet<PisAppointmentType> PisAppointmentType { get; set; }
        public virtual DbSet<PisAttributes> PisAttributes { get; set; }
        public virtual DbSet<PisAwards> PisAwards { get; set; }
        public virtual DbSet<PisBankPayroll> PisBankPayroll { get; set; }
        public virtual DbSet<PisDarbandi> PisDarbandi { get; set; }
        public virtual DbSet<PisDeletdFrmFulfildDarb> PisDeletdFrmFulfildDarb { get; set; }
        public virtual DbSet<PisEduBoard> PisEduBoard { get; set; }
        public virtual DbSet<PisEduLevel> PisEduLevel { get; set; }
        public virtual DbSet<PisEducation> PisEducation { get; set; }
        public virtual DbSet<PisEmpAdvDedDtl> PisEmpAdvDedDtl { get; set; }
        public virtual DbSet<PisEmpBarga> PisEmpBarga { get; set; }
        public virtual DbSet<PisEmpDep> PisEmpDep { get; set; }
        public virtual DbSet<PisEmpDepSource> PisEmpDepSource { get; set; }
        public virtual DbSet<PisEmpInsurancePaid> PisEmpInsurancePaid { get; set; }
        public virtual DbSet<PisEmpLoans> PisEmpLoans { get; set; }
        public virtual DbSet<PisEmpLongLeaves> PisEmpLongLeaves { get; set; }
        public virtual DbSet<PisEmpMedExpense> PisEmpMedExpense { get; set; }
        public virtual DbSet<PisEmpPunishmnts> PisEmpPunishmnts { get; set; }
        public virtual DbSet<PisEmpSrvcDtls> PisEmpSrvcDtls { get; set; }
        public virtual DbSet<PisEmpSuspends> PisEmpSuspends { get; set; }
        public virtual DbSet<PisEmpTrnsfrRec> PisEmpTrnsfrRec { get; set; }
        public virtual DbSet<PisEmployeeMaster> PisEmployeeMaster { get; set; }
        public virtual DbSet<PisForeignVisits> PisForeignVisits { get; set; }
        public virtual DbSet<PisFulfilledDarbandi> PisFulfilledDarbandi { get; set; }
        public virtual DbSet<PisGeoRegion> PisGeoRegion { get; set; }
        public virtual DbSet<PisHajiri> PisHajiri { get; set; }
        public virtual DbSet<PisInternalTransfer> PisInternalTransfer { get; set; }
        public virtual DbSet<PisLandBldngs> PisLandBldngs { get; set; }
        public virtual DbSet<PisLoanDhitoGiven> PisLoanDhitoGiven { get; set; }
        public virtual DbSet<PisLoanDhitoTaken> PisLoanDhitoTaken { get; set; }
        public virtual DbSet<PisLocalPostMaster> PisLocalPostMaster { get; set; }
        public virtual DbSet<PisNijamatiSewaSamuha> PisNijamatiSewaSamuha { get; set; }
        public virtual DbSet<PisOrnaments> PisOrnaments { get; set; }
        public virtual DbSet<PisOtherAddSub> PisOtherAddSub { get; set; }
        public virtual DbSet<PisPayrolls> PisPayrolls { get; set; }
        public virtual DbSet<PisPdOrgInvlvmnt> PisPdOrgInvlvmnt { get; set; }
        public virtual DbSet<PisPdSrvcDtls> PisPdSrvcDtls { get; set; }
        public virtual DbSet<PisPersonVisitRecrd> PisPersonVisitRecrd { get; set; }
        public virtual DbSet<PisPostMaster> PisPostMaster { get; set; }
        public virtual DbSet<PisPrizes> PisPrizes { get; set; }
        public virtual DbSet<PisPublication> PisPublication { get; set; }
        public virtual DbSet<PisPyrollLoanDtls> PisPyrollLoanDtls { get; set; }
        public virtual DbSet<PisPyrollOthrDtls> PisPyrollOthrDtls { get; set; }
        public virtual DbSet<PisReplacedInDarbandi> PisReplacedInDarbandi { get; set; }
        public virtual DbSet<PisServiceStatus> PisServiceStatus { get; set; }
        public virtual DbSet<PisSgnfcntWork> PisSgnfcntWork { get; set; }
        public virtual DbSet<PisShareBankbalance> PisShareBankbalance { get; set; }
        public virtual DbSet<PisTraining> PisTraining { get; set; }
        public virtual DbSet<PisVisitedCountries> PisVisitedCountries { get; set; }
        public virtual DbSet<PisWorkshop> PisWorkshop { get; set; }
        public virtual DbSet<PmsYojtype> PmsYojtype { get; set; }
        public virtual DbSet<RentDarRate> RentDarRate { get; set; }
        public virtual DbSet<Renttype> Renttype { get; set; }
        public virtual DbSet<ReportGeneral> ReportGeneral { get; set; }
        public virtual DbSet<SanitationGroup> SanitationGroup { get; set; }
        public virtual DbSet<SanitationRate> SanitationRate { get; set; }
        public virtual DbSet<SanitationSubgroup> SanitationSubgroup { get; set; }
        public virtual DbSet<ServiceChargeMaster> ServiceChargeMaster { get; set; }
        public virtual DbSet<Spacemeasuringunits> Spacemeasuringunits { get; set; }
        public virtual DbSet<Storedbills> Storedbills { get; set; }
        public virtual DbSet<SubModuleSource> SubModuleSource { get; set; }
        public virtual DbSet<SubjectArea> SubjectArea { get; set; }
        public virtual DbSet<SvBusinessmaster> SvBusinessmaster { get; set; }
        public virtual DbSet<SvConstructions> SvConstructions { get; set; }
        public virtual DbSet<SvHouses> SvHouses { get; set; }
        public virtual DbSet<SvLands> SvLands { get; set; }
        public virtual DbSet<SvLandsmultievaluationdetail> SvLandsmultievaluationdetail { get; set; }
        public virtual DbSet<SvPeople> SvPeople { get; set; }
        public virtual DbSet<SvTbhousekittanumber> SvTbhousekittanumber { get; set; }
        public virtual DbSet<SvVehiclemaster> SvVehiclemaster { get; set; }
        public virtual DbSet<TaxAddtnlChrgDtls> TaxAddtnlChrgDtls { get; set; }
        public virtual DbSet<TaxMalpot> TaxMalpot { get; set; }
        public virtual DbSet<TaxMalpotHistory> TaxMalpotHistory { get; set; }
        public virtual DbSet<TaxRateCeiling> TaxRateCeiling { get; set; }
        public virtual DbSet<TaxRental> TaxRental { get; set; }
        public virtual DbSet<TaxRtRentdtl> TaxRtRentdtl { get; set; }
        public virtual DbSet<TaxSanitation> TaxSanitation { get; set; }
        public virtual DbSet<TaxThliIssuedCntr> TaxThliIssuedCntr { get; set; }
        public virtual DbSet<Tbhousekittanumber> Tbhousekittanumber { get; set; }
        public virtual DbSet<TblBankAccntType> TblBankAccntType { get; set; }
        public virtual DbSet<TblBankFinanceInstitutue> TblBankFinanceInstitutue { get; set; }
        public virtual DbSet<TblBgtMgmt> TblBgtMgmt { get; set; }
        public virtual DbSet<TblBgtMgmtExp> TblBgtMgmtExp { get; set; }
        public virtual DbSet<TblBgtMgmtExpOrg> TblBgtMgmtExpOrg { get; set; }
        public virtual DbSet<TblBgtMgmtExpRelease> TblBgtMgmtExpRelease { get; set; }
        public virtual DbSet<TblBgtMgmtOrg> TblBgtMgmtOrg { get; set; }
        public virtual DbSet<TblBgtMgmtRelease> TblBgtMgmtRelease { get; set; }
        public virtual DbSet<TblBgtMgmtSrc> TblBgtMgmtSrc { get; set; }
        public virtual DbSet<TblBgtMgmtSrcOrg> TblBgtMgmtSrcOrg { get; set; }
        public virtual DbSet<TblBgtMgmtSrcRelease> TblBgtMgmtSrcRelease { get; set; }
        public virtual DbSet<TblBgtRelease> TblBgtRelease { get; set; }
        public virtual DbSet<TblConstructionOtherCharges> TblConstructionOtherCharges { get; set; }
        public virtual DbSet<TblDataHistory> TblDataHistory { get; set; }
        public virtual DbSet<TblDegister> TblDegister { get; set; }
        public virtual DbSet<TblKharidaAadash> TblKharidaAadash { get; set; }
        public virtual DbSet<TblLandOtherCharges> TblLandOtherCharges { get; set; }
        public virtual DbSet<TblMalpotOtherCharges> TblMalpotOtherCharges { get; set; }
        public virtual DbSet<TblNaliType> TblNaliType { get; set; }
        public virtual DbSet<TblOrganizationmaster> TblOrganizationmaster { get; set; }
        public virtual DbSet<TblPaymentOrder> TblPaymentOrder { get; set; }
        public virtual DbSet<TblPaymentOrderDetails> TblPaymentOrderDetails { get; set; }
        public virtual DbSet<TblPaymentProcess> TblPaymentProcess { get; set; }
        public virtual DbSet<TblPaymentType> TblPaymentType { get; set; }
        public virtual DbSet<TblPropertyTax> TblPropertyTax { get; set; }
        public virtual DbSet<TblSanitaionTax> TblSanitaionTax { get; set; }
        public virtual DbSet<TblStatusDetails> TblStatusDetails { get; set; }
        public virtual DbSet<TblTaxType> TblTaxType { get; set; }
        public virtual DbSet<TblTaxsourcerecordnew> TblTaxsourcerecordnew { get; set; }
        public virtual DbSet<TblTolabikasaOrg> TblTolabikasaOrg { get; set; }
        public virtual DbSet<TblVehicleParts> TblVehicleParts { get; set; }
        public virtual DbSet<Tblbilltype> Tblbilltype { get; set; }
        public virtual DbSet<TblbusinessServiceChMst> TblbusinessServiceChMst { get; set; }
        public virtual DbSet<Tblexeversion> Tblexeversion { get; set; }
        public virtual DbSet<Tblfywisebtrates> Tblfywisebtrates { get; set; }
        public virtual DbSet<Tblfywisempotassrate> Tblfywisempotassrate { get; set; }
        public virtual DbSet<TblhlAddSubtract> TblhlAddSubtract { get; set; }
        public virtual DbSet<TbllandTypeArea> TbllandTypeArea { get; set; }
        public virtual DbSet<Tblmalpotgroup> Tblmalpotgroup { get; set; }
        public virtual DbSet<Tblmalpotrates> Tblmalpotrates { get; set; }
        public virtual DbSet<Tblmalpotsubgroup> Tblmalpotsubgroup { get; set; }
        public virtual DbSet<TbltaxFineRebate> TbltaxFineRebate { get; set; }
        public virtual DbSet<Tbltaxcalculationroka> Tbltaxcalculationroka { get; set; }
        public virtual DbSet<TblvehSerChMstr> TblvehSerChMstr { get; set; }
        public virtual DbSet<Tbusersecurityrights> Tbusersecurityrights { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Userassignments> Userassignments { get; set; }
        public virtual DbSet<Usermaster> Usermaster { get; set; }
        public virtual DbSet<Vdc> Vdc { get; set; }
        public virtual DbSet<WardMaster> WardMaster { get; set; }
        public virtual DbSet<Zone> Zone { get; set; } 
        
        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=IMIS;Pooling=true");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<ImisMenu>().ToTable("Imis_Menu");
            modelBuilder.Entity<Usermaster>().ToTable("Usermaster");
            modelBuilder.Entity<AccAccMaster>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("ACC_ACC_MASTER_pkey");

                entity.ToTable("ACC_ACC_MASTER");

                entity.HasIndex(e => e.TypeId);

                entity.Property(e => e.AccId)
                    .HasColumnName("ACC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccCode)
                    .HasColumnName("ACC_CODE")
                    .HasMaxLength(200);

                entity.Property(e => e.AccType)
                    .HasColumnName("ACC_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.DispCode)
                    .HasColumnName("DISP_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.DispName)
                    .HasColumnName("DISP_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.GrpLevel).HasColumnName("GRP_LEVEL");

                entity.Property(e => e.IsBudgetable)
                    .HasColumnName("IS_BUDGETABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFixed)
                    .HasColumnName("IS_FIXED")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHide)
                    .HasColumnName("IS_HIDE")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTransactable)
                    .HasColumnName("IS_TRANSACTABLE")
                    .HasMaxLength(1);

                entity.Property(e => e.Iscapitalcurrent).HasColumnName("ISCAPITALCURRENT");

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ParentAccId).HasColumnName("PARENT_ACC_ID");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AccAccMaster)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ACC_ACC_MASTER_TYPID");
            });

            modelBuilder.Entity<AccAsuliBibaran>(entity =>
            {
                entity.HasKey(e => e.AsuliId)
                    .HasName("ACC_ASULI_BIBARAN_pkey");

                entity.ToTable("ACC_ASULI_BIBARAN");

                entity.HasIndex(e => e.PersonTypeId);

                entity.Property(e => e.AsuliId)
                    .HasColumnName("ASULI_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmtTaken).HasColumnName("AMT_TAKEN");

                entity.Property(e => e.CollectReason)
                    .HasColumnName("COLLECT_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.PaymentPersonId).HasColumnName("PAYMENT_PERSON_ID");

                entity.Property(e => e.PersonName)
                    .HasColumnName("PERSON_NAME")
                    .HasMaxLength(90);

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.PeskiAmt).HasColumnName("PESKI_AMT");

                entity.Property(e => e.PeskiEmployeeId).HasColumnName("PESKI_EMPLOYEE_ID");

                entity.Property(e => e.PropertyDetails)
                    .HasColumnName("PROPERTY_DETAILS")
                    .HasMaxLength(200);

                entity.Property(e => e.PropertyEmployeeId).HasColumnName("PROPERTY_EMPLOYEE_ID");

                entity.Property(e => e.PropertyRoka)
                    .HasColumnName("PROPERTY_ROKA")
                    .HasMaxLength(200);

                entity.Property(e => e.ResponsiveTaken)
                    .HasColumnName("RESPONSIVE_TAKEN")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkName)
                    .HasColumnName("WORK_NAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.AccAsuliBibaran)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_ACC_PERSON_TYPE");
            });

            modelBuilder.Entity<AccBankGrnty>(entity =>
            {
                entity.HasKey(e => e.GrntyId)
                    .HasName("ACC_BANK_GRNTY_pkey");

                entity.ToTable("ACC_BANK_GRNTY");

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.GrntyId)
                    .HasColumnName("GRNTY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EntryDatetime).HasColumnName("ENTRY_DATETIME");

                entity.Property(e => e.ExpryVsDate)
                    .HasColumnName("EXPRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.GrntyAmount).HasColumnName("GRNTY_AMOUNT");

                entity.Property(e => e.GrntyNo)
                    .HasColumnName("GRNTY_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.GrntyType)
                    .HasColumnName("GRNTY_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.GrntyVsDate)
                    .HasColumnName("GRNTY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.MagCn)
                    .HasColumnName("MAG_CN")
                    .HasMaxLength(15);

                entity.Property(e => e.MagPs)
                    .HasColumnName("MAG_PS")
                    .HasMaxLength(15);

                entity.Property(e => e.MagVsDate)
                    .HasColumnName("MAG_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PhukuwaCn)
                    .HasColumnName("PHUKUWA_CN")
                    .HasMaxLength(15);

                entity.Property(e => e.PhukuwaPs)
                    .HasColumnName("PHUKUWA_PS")
                    .HasMaxLength(15);

                entity.Property(e => e.PhukuwaVsDate)
                    .HasColumnName("PHUKUWA_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccBankGrnty)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_GRNTY_PERSON_ORG_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccBankGrnty)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_GRNTY_WORK_ID");
            });

            modelBuilder.Entity<AccBankStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_BANK_STATEMENT");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.BankTransactionId).HasColumnName("BANK_TRANSACTION_ID");

                entity.Property(e => e.ChequeNo)
                    .HasColumnName("CHEQUE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.CrAmt).HasColumnName("CR_AMT");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.DrAmt).HasColumnName("DR_AMT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("TRANSACTION_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionDateEn).HasColumnName("TRANSACTION_DATE_EN");
            });

            modelBuilder.Entity<AccBankTrans>(entity =>
            {
                entity.HasKey(e => e.BankTransId)
                    .HasName("ACC_BANK_TRANS_pkey");

                entity.ToTable("ACC_BANK_TRANS");

                entity.HasIndex(e => e.BankId);

                entity.HasIndex(e => e.BillId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.BankTransId)
                    .HasColumnName("BANK_TRANS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.CrAmt)
                    .HasColumnName("CR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.DrAmt)
                    .HasColumnName("DR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.IsOfLastyear)
                    .HasColumnName("IS_OF_LASTYEAR")
                    .HasMaxLength(2);

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.VchrDateNep)
                    .HasColumnName("VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AccBankTrans)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_BANK_BANK_ID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.AccBankTrans)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BANK_BILL_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccBankTrans)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK__BANK_VCHR_ID");
            });

            modelBuilder.Entity<AccBgtAllocate>(entity =>
            {
                entity.HasKey(e => e.BgtAllocateId)
                    .HasName("ACC_BGT_ALLOCATE_pkey");

                entity.ToTable("ACC_BGT_ALLOCATE");

                entity.Property(e => e.BgtAllocateId)
                    .HasColumnName("BGT_ALLOCATE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AllocatedDateNp)
                    .HasColumnName("ALLOCATED_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.EntryDatetime).HasColumnName("ENTRY_DATETIME");

                entity.Property(e => e.EntryUserId).HasColumnName("ENTRY_USER_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.RevisedAmount).HasColumnName("REVISED_AMOUNT");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.UpdateDatetime).HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
            });

            modelBuilder.Entity<AccBgtRvsn>(entity =>
            {
                entity.ToTable("ACC_BGT_RVSN");

                entity.HasIndex(e => e.BgtAlctnId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BgtAlctnId).HasColumnName("BGT_ALCTN_ID");

                entity.Property(e => e.RvsnDateNp)
                    .HasColumnName("RVSN_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.RvsnReason)
                    .HasColumnName("RVSN_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDatetime).HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");

                entity.HasOne(d => d.BgtAlctn)
                    .WithMany(p => p.AccBgtRvsn)
                    .HasForeignKey(d => d.BgtAlctnId)
                    .HasConstraintName("FK_ACC_BGT_RVSN_BGT_ID");
            });

            modelBuilder.Entity<AccBgtTransfer>(entity =>
            {
                entity.ToTable("ACC_BGT_TRANSFER");

                entity.HasIndex(e => e.BgtAlctnId);

                entity.HasIndex(e => e.FromAccId);

                entity.HasIndex(e => e.ToAccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BgtAlctnId).HasColumnName("BGT_ALCTN_ID");

                entity.Property(e => e.FromAccId).HasColumnName("FROM_ACC_ID");

                entity.Property(e => e.ToAccId).HasColumnName("TO_ACC_ID");

                entity.Property(e => e.TrnsfrDateNp)
                    .HasColumnName("TRNSFR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.TrnsfrReason)
                    .HasColumnName("TRNSFR_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDatetime).HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");

                entity.HasOne(d => d.BgtAlctn)
                    .WithMany(p => p.AccBgtTransfer)
                    .HasForeignKey(d => d.BgtAlctnId)
                    .HasConstraintName("FK_TRNSFR_BGT_ALCTN_ID");

                entity.HasOne(d => d.FromAcc)
                    .WithMany(p => p.AccBgtTransferFromAcc)
                    .HasForeignKey(d => d.FromAccId)
                    .HasConstraintName("FK_FROM_ACC_ID");

                entity.HasOne(d => d.ToAcc)
                    .WithMany(p => p.AccBgtTransferToAcc)
                    .HasForeignKey(d => d.ToAccId)
                    .HasConstraintName("FK_TO_ACC_ID");
            });

            modelBuilder.Entity<AccBudjetSource>(entity =>
            {
                entity.ToTable("ACC_BUDJET_SOURCE");

                entity.HasIndex(e => e.MinAccId);

                entity.HasIndex(e => e.SourceId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.MinAccId).HasColumnName("MIN_ACC_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceId).HasColumnName("SOURCE_ID");

                entity.HasOne(d => d.MinAcc)
                    .WithMany(p => p.AccBudjetSource)
                    .HasForeignKey(d => d.MinAccId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MIN_ACC");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.AccBudjetSource)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_BUD_SOURCE");
            });

            modelBuilder.Entity<AccCashTrans>(entity =>
            {
                entity.HasKey(e => e.CashTransId)
                    .HasName("ACC_CASH_TRANS_pkey");

                entity.ToTable("ACC_CASH_TRANS");

                entity.HasIndex(e => e.BillId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.CashTransId)
                    .HasColumnName("CASH_TRANS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.CrAmt)
                    .HasColumnName("CR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.DrAmt)
                    .HasColumnName("DR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.IncomeExpTypeId).HasColumnName("INCOME_EXP_TYPE_ID");

                entity.Property(e => e.IsOfLastyear)
                    .HasColumnName("IS_OF_LASTYEAR")
                    .HasMaxLength(2);

                entity.Property(e => e.VchrDateNep)
                    .HasColumnName("VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.AccCashTrans)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_CASH_BILL_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccCashTrans)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_CASH_VCHR_ID");
            });

            modelBuilder.Entity<AccChequeTypes>(entity =>
            {
                entity.HasKey(e => e.ChequeTypeId)
                    .HasName("ACC_CHEQUE_TYPES_pkey");

                entity.ToTable("ACC_CHEQUE_TYPES");

                entity.Property(e => e.ChequeTypeId)
                    .HasColumnName("CHEQUE_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChequeType)
                    .HasColumnName("CHEQUE_TYPE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AccCurrencty>(entity =>
            {
                entity.ToTable("ACC_CURRENCTY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName).HasColumnName("ENG_NAME");

                entity.Property(e => e.NpName).HasColumnName("NP_NAME");

                entity.Property(e => e.Symbol)
                    .HasColumnName("SYMBOL")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<AccCurrenctyRate>(entity =>
            {
                entity.ToTable("ACC_CURRENCTY_RATE");

                entity.HasIndex(e => e.CurrencyId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.NpDate)
                    .HasColumnName("NP_DATE")
                    .HasMaxLength(15);

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AccCurrenctyRate)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_ACC_CURRENCTY_RATE");
            });

            modelBuilder.Entity<AccDhrtiBillDtl>(entity =>
            {
                entity.HasKey(e => e.DhrtiDtlId)
                    .HasName("ACC_DHRTI_BILL_DTL_pkey");

                entity.ToTable("ACC_DHRTI_BILL_DTL");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.DhrtiDtlId)
                    .HasColumnName("DHRTI_DTL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BillDateNp)
                    .HasColumnName("BILL_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.BillNo)
                    .HasColumnName("BILL_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.CounterId).HasColumnName("COUNTER_ID");

                entity.Property(e => e.DhrtiMasterId).HasColumnName("DHRTI_MASTER_ID");

                entity.Property(e => e.OrderInBill).HasColumnName("ORDER_IN_BILL");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.AccDhrtiBillDtl)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_AC_DHRTI_DTL_ACC_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccDhrtiBillDtl)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_AC_DHRTI_DTL_VCHR_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccDhrtiBillDtl)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("SYS_C004345");
            });

            modelBuilder.Entity<AccDhrtiBillMaster>(entity =>
            {
                entity.HasKey(e => e.DhrtiMasterId)
                    .HasName("ACC_DHRTI_BILL_MASTER_pkey");

                entity.ToTable("ACC_DHRTI_BILL_MASTER");

                entity.HasIndex(e => e.Billtypeid);

                entity.HasIndex(e => e.SubModuleId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.DhrtiMasterId)
                    .HasColumnName("DHRTI_MASTER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.BankAmt).HasColumnName("BANK_AMT");

                entity.Property(e => e.BillNo)
                    .HasColumnName("BILL_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.BillNoManual)
                    .HasColumnName("BILL_NO_MANUAL")
                    .HasMaxLength(25);

                entity.Property(e => e.Billtypeid).HasColumnName("BILLTYPEID");

                entity.Property(e => e.BllDateNp)
                    .HasColumnName("BLL_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.CancelDate)
                    .HasColumnName("CANCEL_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CancelReason)
                    .HasColumnName("CANCEL_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.CashAmt).HasColumnName("CASH_AMT");

                entity.Property(e => e.CounterId).HasColumnName("COUNTER_ID");

                entity.Property(e => e.DateEditTime).HasColumnName("DATE_EDIT_TIME");

                entity.Property(e => e.DateEntryTime).HasColumnName("DATE_ENTRY_TIME");

                entity.Property(e => e.DateEntryVsDate)
                    .HasColumnName("DATE_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WardNo).HasColumnName("WARD_NO");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Billtype)
                    .WithMany(p => p.AccDhrtiBillMaster)
                    .HasForeignKey(d => d.Billtypeid)
                    .HasConstraintName("SYS_C004389");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.AccDhrtiBillMaster)
                    .HasForeignKey(d => d.SubModuleId)
                    .HasConstraintName("SYS_C004315");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccDhrtiBillMaster)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_AC_DHRTI_MST_VCHRID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccDhrtiBillMaster)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("SYS_C004344");
            });

            modelBuilder.Entity<AccExpensesDetails>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("ACC_EXPENSES_DETAILS_pkey");

                entity.ToTable("ACC_EXPENSES_DETAILS");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.PaymentSlipId);

                entity.HasIndex(e => e.PersonTypeId);

                entity.HasIndex(e => e.TransTypeId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.ExpenseId)
                    .HasColumnName("EXPENSE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Advexptype)
                    .HasColumnName("ADVEXPTYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.CrAmt).HasColumnName("CR_AMT");

                entity.Property(e => e.DrAmt).HasColumnName("DR_AMT");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderInPaymentSlip).HasColumnName("ORDER_IN_PAYMENT_SLIP");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.PadadhikariId).HasColumnName("PADADHIKARI_ID");

                entity.Property(e => e.PaymentSlipId).HasColumnName("PAYMENT_SLIP_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.UcId).HasColumnName("UC_ID");

                entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WardId).HasColumnName("WARD_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.AccExpensesDetails)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_DETAIL_ACC_ID");

                entity.HasOne(d => d.PaymentSlip)
                    .WithMany(p => p.AccExpensesDetails)
                    .HasForeignKey(d => d.PaymentSlipId)
                    .HasConstraintName("FK_DETAIL_PAMENT_SLIPID");

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.AccExpensesDetails)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_DETAIL_PERSON_TYPE_ID");

                entity.HasOne(d => d.TransType)
                    .WithMany(p => p.AccExpensesDetails)
                    .HasForeignKey(d => d.TransTypeId)
                    .HasConstraintName("FK_ACC_TRANS_TYPE");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccExpensesDetails)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_DETAIL_WWORK_ID");
            });

            modelBuilder.Entity<AccFundProvidrMstr>(entity =>
            {
                entity.HasKey(e => e.ProviderId)
                    .HasName("ACC_FUND_PROVIDR_MSTR_pkey");

                entity.ToTable("ACC_FUND_PROVIDR_MSTR");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("PROVIDER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chairman)
                    .HasColumnName("CHAIRMAN")
                    .HasMaxLength(70);

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("CONTACT_PERSON")
                    .HasMaxLength(70);

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(50);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccIncomeRate>(entity =>
            {
                entity.HasKey(e => e.RateId)
                    .HasName("ACC_INCOME_RATE_pkey");

                entity.ToTable("ACC_INCOME_RATE");

                entity.Property(e => e.RateId)
                    .HasColumnName("RATE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Rate).HasColumnName("RATE");
            });

            modelBuilder.Entity<AccLastYrPeski>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("ACC_LAST_YR_PESKI_pkey");

                entity.ToTable("ACC_LAST_YR_PESKI");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvanceType)
                    .HasColumnName("ADVANCE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.TotalPesRem).HasColumnName("TOTAL_PES_REM");
            });

            modelBuilder.Entity<AccLastyearAdvDetails>(entity =>
            {
                entity.ToTable("ACC_LASTYEAR_ADV_DETAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AddDate)
                    .HasColumnName("ADD_DATE")
                    .HasMaxLength(15);

                entity.Property(e => e.AddUserId).HasColumnName("ADD_USER_ID");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.DrAmount).HasColumnName("DR_AMOUNT");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(15);

                entity.Property(e => e.LastYrPeskiId).HasColumnName("LAST_YR_PESKI_ID");

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PAYMENT_TYPE_ID");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(2);

                entity.Property(e => e.VhcrId).HasColumnName("VHCR_ID");

                entity.Property(e => e.VoucherDate)
                    .HasColumnName("VOUCHER_DATE")
                    .HasMaxLength(15);

                entity.Property(e => e.VoucherNo)
                    .HasColumnName("VOUCHER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");
            });

            modelBuilder.Entity<AccOrgMaster>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("ACC_ORG_MASTER_pkey");

                entity.ToTable("ACC_ORG_MASTER");

                entity.Property(e => e.OrgId)
                    .HasColumnName("ORG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(90);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(30);

                entity.Property(e => e.District).HasColumnName("DISTRICT");

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(100);

                entity.Property(e => e.Head)
                    .HasColumnName("HEAD")
                    .HasMaxLength(50);

                entity.Property(e => e.Ministry).HasColumnName("MINISTRY");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(90);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(90);

                entity.Property(e => e.OrcAccTypeId).HasColumnName("ORC_ACC_TYPE_ID");

                entity.Property(e => e.OrgMasterId).HasColumnName("ORG_MASTER_ID");

                entity.Property(e => e.PanNo)
                    .HasColumnName("PAN_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(40);

                entity.Property(e => e.RegNo)
                    .HasColumnName("REG_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.RelatedPerson)
                    .HasColumnName("RELATED_PERSON")
                    .HasMaxLength(100);

                entity.Property(e => e.Sapati)
                    .HasColumnName("SAPATI")
                    .HasMaxLength(2);

                entity.Property(e => e.VatNo)
                    .HasColumnName("VAT_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.Vdc).HasColumnName("VDC");

                entity.Property(e => e.Zone).HasColumnName("ZONE");
            });

            modelBuilder.Entity<AccPadadhikariMstr>(entity =>
            {
                entity.HasKey(e => e.PadadikariId)
                    .HasName("ACC_PADADHIKARI_MSTR_pkey");

                entity.ToTable("ACC_PADADHIKARI_MSTR");

                entity.HasIndex(e => e.PostId);

                entity.Property(e => e.PadadikariId)
                    .HasColumnName("PADADIKARI_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.CitizenshipNo)
                    .HasColumnName("CITIZENSHIP_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.CitznIssuedDate)
                    .HasColumnName("CITZN_ISSUED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CitznIssuedDistrId).HasColumnName("CITZN_ISSUED_DISTR_ID");

                entity.Property(e => e.CurrentPostAppointDate)
                    .HasColumnName("CURRENT_POST_APPOINT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasMaxLength(10);

                entity.Property(e => e.DateOfBirthAd).HasColumnName("DATE_OF_BIRTH_AD");

                entity.Property(e => e.DistrictId).HasColumnName("DISTRICT_ID");

                entity.Property(e => e.ElectedDateNp)
                    .HasColumnName("ELECTED_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstAppointDate)
                    .HasColumnName("FIRST_APPOINT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.FirstAppointPostId).HasColumnName("FIRST_APPOINT_POST_ID");

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1);

                entity.Property(e => e.GfOcupation).HasColumnName("GF_OCUPATION");

                entity.Property(e => e.GrandfatherName)
                    .HasColumnName("GRANDFATHER_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.IsToiletInHome)
                    .HasColumnName("IS_TOILET_IN_HOME")
                    .HasMaxLength(1);

                entity.Property(e => e.LastNameEn)
                    .HasColumnName("LAST_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.LastNameNp)
                    .HasColumnName("LAST_NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.MarriedStatus)
                    .HasColumnName("MARRIED_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.MotherLangId).HasColumnName("MOTHER_LANG_ID");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.NoOfDaughter).HasColumnName("NO_OF_DAUGHTER");

                entity.Property(e => e.NoOfSon).HasColumnName("NO_OF_SON");

                entity.Property(e => e.POcupation).HasColumnName("P_OCUPATION");

                entity.Property(e => e.ParentName)
                    .HasColumnName("PARENT_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(50);

                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                entity.Property(e => e.PreExperience)
                    .HasColumnName("PRE_EXPERIENCE")
                    .HasMaxLength(50);

                entity.Property(e => e.Qualification)
                    .HasColumnName("QUALIFICATION")
                    .HasMaxLength(100);

                entity.Property(e => e.ReligionId).HasColumnName("RELIGION_ID");

                entity.Property(e => e.RetireDate)
                    .HasColumnName("RETIRE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.SOcupation).HasColumnName("S_OCUPATION");

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(70);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(10);

                entity.Property(e => e.TrackId).HasColumnName("TRACK_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.VdcId).HasColumnName("VDC_ID");

                entity.Property(e => e.WardNo).HasColumnName("WARD_NO");

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.AccPadadhikariMstr)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_POST_ID");
            });

            modelBuilder.Entity<AccPadadhikariPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("ACC_PADADHIKARI_POST_pkey");

                entity.ToTable("ACC_PADADHIKARI_POST");

                entity.Property(e => e.PostId)
                    .HasColumnName("POST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DurationInYrs).HasColumnName("DURATION_IN_YRS");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.PostLevel).HasColumnName("POST_LEVEL");
            });

            modelBuilder.Entity<AccPaymentClearance>(entity =>
            {
                entity.ToTable("ACC_PAYMENT_CLEARANCE");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.BudgetAccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.AccPaymentClearanceAcc)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_ACPAYCLEAR_ACCID");

                entity.HasOne(d => d.BudgetAcc)
                    .WithMany(p => p.AccPaymentClearanceBudgetAcc)
                    .HasForeignKey(d => d.BudgetAccId)
                    .HasConstraintName("FK_ACPAYCLEAR_BUDGET");
            });

            modelBuilder.Entity<AccPaymentCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_PAYMENT_CREDIT");

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");
            });

            modelBuilder.Entity<AccPaymentDeduction>(entity =>
            {
                entity.ToTable("ACC_PAYMENT_DEDUCTION");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.BudgetAccId);

                entity.HasIndex(e => e.PaymentId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.Deductiontype)
                    .HasColumnName("DEDUCTIONTYPE")
                    .HasMaxLength(5);

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.AccPaymentDeductionAcc)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_ACID_PAY_DEDU");

                entity.HasOne(d => d.BudgetAcc)
                    .WithMany(p => p.AccPaymentDeductionBudgetAcc)
                    .HasForeignKey(d => d.BudgetAccId)
                    .HasConstraintName("FK_BUDGETID_PAY_DEDU");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.AccPaymentDeduction)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PAYID_DEDUC");
            });

            modelBuilder.Entity<AccPaymentDetails>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailId)
                    .HasName("ACC_PAYMENT_DETAILS_pkey");

                entity.ToTable("ACC_PAYMENT_DETAILS");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.BudgetAccId);

                entity.HasIndex(e => e.PaymentId);

                entity.HasIndex(e => e.PersonTypeId);

                entity.HasIndex(e => e.TransTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.PaymentDetailId)
                    .HasColumnName("PAYMENT_DETAIL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AdvanceType)
                    .HasColumnName("ADVANCE_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Advexptype)
                    .HasColumnName("ADVEXPTYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.CrAmt)
                    .HasColumnName("CR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.DrAmt)
                    .HasColumnName("DR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ExpireDateNp)
                    .HasColumnName("EXPIRE_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderInPaymentSlip).HasColumnName("ORDER_IN_PAYMENT_SLIP");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.PadadhikariId).HasColumnName("PADADHIKARI_ID");

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.Property(e => e.PaymentSlipId).HasColumnName("PAYMENT_SLIP_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.UcId).HasColumnName("UC_ID");

                entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WardId).HasColumnName("WARD_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.AccPaymentDetailsAcc)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_DETAIL_ACC_ID1");

                entity.HasOne(d => d.BudgetAcc)
                    .WithMany(p => p.AccPaymentDetailsBudgetAcc)
                    .HasForeignKey(d => d.BudgetAccId)
                    .HasConstraintName("FK_DTL_BUDGET_ACC_ID1");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.AccPaymentDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PAM_DETAIL_PAYMENT_ID1");

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.AccPaymentDetails)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_DETAIL_PERSON_TYPE_ID1");

                entity.HasOne(d => d.TransType)
                    .WithMany(p => p.AccPaymentDetails)
                    .HasForeignKey(d => d.TransTypeId)
                    .HasConstraintName("FK_ACC_TRANS_TYPE1");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccPaymentDetails)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_PAYMNT_DETL_VCHR_ID1");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccPaymentDetails)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_DETAIL_WORK_ID1");
            });

            modelBuilder.Entity<AccPaymentMaster>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("ACC_PAYMENT_MASTER_pkey");

                entity.ToTable("ACC_PAYMENT_MASTER");

                entity.HasIndex(e => e.PersonTypeId);

                entity.HasIndex(e => e.SubModuleId);

                entity.HasIndex(e => e.TransTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PAYMENT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccDeductDepVchrDate)
                    .HasColumnName("ACC_DEDUCT_DEP_VCHR_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AccDeductDepVchrId).HasColumnName("ACC_DEDUCT_DEP_VCHR_ID");

                entity.Property(e => e.AdvClearedFromBank).HasColumnName("ADV_CLEARED_FROM_BANK");

                entity.Property(e => e.AdvClearedFromBill).HasColumnName("ADV_CLEARED_FROM_BILL");

                entity.Property(e => e.AdvClearedFromCash).HasColumnName("ADV_CLEARED_FROM_CASH");

                entity.Property(e => e.Advexptype)
                    .HasColumnName("ADVEXPTYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.BillAmt).HasColumnName("BILL_AMT");

                entity.Property(e => e.BillNo)
                    .HasColumnName("BILL_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.CashPayment).HasColumnName("CASH_PAYMENT");

                entity.Property(e => e.ChequePayment).HasColumnName("CHEQUE_PAYMENT");

                entity.Property(e => e.ContractTaxDeduction).HasColumnName("CONTRACT_TAX_DEDUCTION");

                entity.Property(e => e.CrAmount).HasColumnName("CR_AMOUNT");

                entity.Property(e => e.DeductDepVchrDateNep)
                    .HasColumnName("DEDUCT_DEP_VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.DeductDepVchrId).HasColumnName("DEDUCT_DEP_VCHR_ID");

                entity.Property(e => e.ExpireDateNp)
                    .HasColumnName("EXPIRE_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.IncomeTaxDeduction).HasColumnName("INCOME_TAX_DEDUCTION");

                entity.Property(e => e.Ispeski)
                    .HasColumnName("ISPESKI")
                    .HasMaxLength(1);

                entity.Property(e => e.LastYearsAdvDeduction).HasColumnName("LAST_YEARS_ADV_DEDUCTION");

                entity.Property(e => e.LyAdvClearedFromBank).HasColumnName("LY_ADV_CLEARED_FROM_BANK");

                entity.Property(e => e.LyAdvClearedFromBill).HasColumnName("LY_ADV_CLEARED_FROM_BILL");

                entity.Property(e => e.LyAdvClearedFromCash).HasColumnName("LY_ADV_CLEARED_FROM_CASH");

                entity.Property(e => e.OtherDeduction).HasColumnName("OTHER_DEDUCTION");

                entity.Property(e => e.PaymentDescription)
                    .HasColumnName("PAYMENT_DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.RetentionMoneyEduction).HasColumnName("RETENTION_MONEY_EDUCTION");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.SubjectAreaId).HasColumnName("SUBJECT_AREA_ID");

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");

                entity.Property(e => e.VatDeduction).HasColumnName("VAT_DEDUCTION");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.AccPaymentMaster)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_ACC_PAMT_PER_TYPE_ID");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.AccPaymentMaster)
                    .HasForeignKey(d => d.SubModuleId)
                    .HasConstraintName("FK_ACC_PAMT_MST_SUB_MODL");

                entity.HasOne(d => d.TransType)
                    .WithMany(p => p.AccPaymentMaster)
                    .HasForeignKey(d => d.TransTypeId)
                    .HasConstraintName("FK_ACC_PAMT_TRANS_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccPaymentMaster)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_ACC_PAMT_MST_VCHR_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccPaymentMaster)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_ACC_PAMT_WORK_ID");
            });

            modelBuilder.Entity<AccReceivable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_RECEIVABLE");

                entity.Property(e => e.Additionalcharges).HasColumnName("ADDITIONALCHARGES");

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Taxtype)
                    .HasColumnName("TAXTYPE")
                    .HasMaxLength(5);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.VchrDate)
                    .HasColumnName("VCHR_DATE")
                    .HasMaxLength(12);

                entity.Property(e => e.Vchrid).HasColumnName("VCHRID");
            });

            modelBuilder.Entity<AccSubModuleType>(entity =>
            {
                entity.HasKey(e => e.SubModuleId)
                    .HasName("ACC_SUB_MODULE_TYPE_pkey");

                entity.ToTable("ACC_SUB_MODULE_TYPE");

                entity.Property(e => e.SubModuleId)
                    .HasColumnName("SUB_MODULE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccExpencesCode)
                    .HasColumnName("ACC_EXPENCES_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.BudgetAccNo)
                    .HasColumnName("BUDGET_ACC_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Iscapital).HasColumnName("ISCAPITAL");

                entity.Property(e => e.Isexpences).HasColumnName("ISEXPENCES");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<AccTransType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("ACC_TRANS_TYPE_pkey");

                entity.ToTable("ACC_TRANS_TYPE");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.NepName)
                    .IsRequired()
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.TypeCode)
                    .IsRequired()
                    .HasColumnName("TYPE_CODE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AccUnauthorised>(entity =>
            {
                entity.HasKey(e => e.UnauthorisedId)
                    .HasName("ACC_UNAUTHORISED_pkey");

                entity.ToTable("ACC_UNAUTHORISED");

                entity.Property(e => e.UnauthorisedId)
                    .HasColumnName("UNAUTHORISED_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FilledbyEmpid).HasColumnName("FILLEDBY_EMPID");

                entity.Property(e => e.InspectAmt).HasColumnName("INSPECT_AMT");

                entity.Property(e => e.InspectDate)
                    .HasColumnName("INSPECT_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.InspectDetails)
                    .HasColumnName("INSPECT_DETAILS")
                    .HasMaxLength(200);

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.UnauthorisedAmt).HasColumnName("UNAUTHORISED_AMT");

                entity.Property(e => e.UnauthorisedDafaId).HasColumnName("UNAUTHORISED_DAFA_ID");

                entity.Property(e => e.VerifiedbyEmpid).HasColumnName("VERIFIEDBY_EMPID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");
            });

            modelBuilder.Entity<AccUserComiteMstr>(entity =>
            {
                entity.ToTable("ACC_USER_COMITE_MSTR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(90);

                entity.Property(e => e.Chairman)
                    .HasColumnName("CHAIRMAN")
                    .HasMaxLength(70);

                entity.Property(e => e.ConcernPerson)
                    .HasColumnName("CONCERN_PERSON")
                    .HasMaxLength(70);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(50);

                entity.Property(e => e.Ward).HasColumnName("WARD");
            });

            modelBuilder.Entity<AccVchrDetails>(entity =>
            {
                entity.HasKey(e => e.VchrDetailId)
                    .HasName("ACC_VCHR_DETAILS_pkey");

                entity.ToTable("ACC_VCHR_DETAILS");

                entity.HasIndex(e => e.SubModuleId);

                entity.HasIndex(e => e.TransTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.VchrTypeId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.VchrDetailId)
                    .HasColumnName("VCHR_DETAIL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AccType)
                    .IsRequired()
                    .HasColumnName("ACC_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.CrAmt)
                    .HasColumnName("CR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.DrAmt)
                    .HasColumnName("DR_AMT")
                    .HasDefaultValueSql("'0'::real");

                entity.Property(e => e.ExpireDateNp)
                    .HasColumnName("EXPIRE_DATE_NP")
                    .HasMaxLength(20);

                entity.Property(e => e.IdFromSrc).HasColumnName("ID_FROM_SRC");

                entity.Property(e => e.IsGroup)
                    .HasColumnName("IS_GROUP")
                    .HasMaxLength(1);

                entity.Property(e => e.IsJafat)
                    .HasColumnName("IS_JAFAT")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPosted)
                    .HasColumnName("IS_POSTED")
                    .HasMaxLength(1);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.VchrDateEng).HasColumnName("VCHR_DATE_ENG");

                entity.Property(e => e.VchrDateNep)
                    .HasColumnName("VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.VchrTypeId).HasColumnName("VCHR_TYPE_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.AccVchrDetails)
                    .HasForeignKey(d => d.SubModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DTL_SUB_MODULEID");

                entity.HasOne(d => d.TransType)
                    .WithMany(p => p.AccVchrDetails)
                    .HasForeignKey(d => d.TransTypeId)
                    .HasConstraintName("FK_DETAIL_TRANS_TYPE_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccVchrDetails)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_DETAIL_ACC_VCHR_ID");

                entity.HasOne(d => d.VchrType)
                    .WithMany(p => p.AccVchrDetails)
                    .HasForeignKey(d => d.VchrTypeId)
                    .HasConstraintName("FK_DETAIL_VCHR_TYPE_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccVchrDetails)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("SYS_C004349");
            });

            modelBuilder.Entity<AccVchrMaster>(entity =>
            {
                entity.HasKey(e => e.VchrId)
                    .HasName("ACC_VCHR_MASTER_pkey");

                entity.ToTable("ACC_VCHR_MASTER");

                entity.HasIndex(e => e.SubModuleId);

                entity.HasIndex(e => e.VchrTypeId);

                entity.Property(e => e.VchrId)
                    .HasColumnName("VCHR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AsuliAmt).HasColumnName("ASULI_AMT");

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.ChequeTypeId).HasColumnName("CHEQUE_TYPE_ID");

                entity.Property(e => e.ContactPhone)
                    .HasColumnName("CONTACT_PHONE")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("FATHER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.GrandFatherName)
                    .HasColumnName("GRAND_FATHER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.InternalLekha)
                    .HasColumnName("INTERNAL_LEKHA")
                    .HasMaxLength(50);

                entity.Property(e => e.IsNikash)
                    .HasColumnName("IS_NIKASH")
                    .HasMaxLength(1);

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPosted)
                    .HasColumnName("IS_POSTED")
                    .HasMaxLength(1);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.NValidAmt).HasColumnName("N_VALID_AMT");

                entity.Property(e => e.NameChequePayee)
                    .HasColumnName("NAME_CHEQUE_PAYEE")
                    .HasMaxLength(100);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(200);

                entity.Property(e => e.NiyamitAmt).HasColumnName("NIYAMIT_AMT");

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.UpdateDate).HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.ValidAmt).HasColumnName("VALID_AMT");

                entity.Property(e => e.VchrDateNep)
                    .HasColumnName("VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrNo).HasColumnName("VCHR_NO");

                entity.Property(e => e.VchrTypeId).HasColumnName("VCHR_TYPE_ID");

                entity.Property(e => e.Wardno)
                    .HasColumnName("WARDNO")
                    .HasMaxLength(10);

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.AccVchrMaster)
                    .HasForeignKey(d => d.SubModuleId)
                    .HasConstraintName("FK_ACC_SUB_MODULE_TYPE");

                entity.HasOne(d => d.VchrType)
                    .WithMany(p => p.AccVchrMaster)
                    .HasForeignKey(d => d.VchrTypeId)
                    .HasConstraintName("FK_MAST_VCHR_TYPE_ID");
            });

            modelBuilder.Entity<AccVchrTypeMaster>(entity =>
            {
                entity.HasKey(e => e.VchrTypeId)
                    .HasName("ACC_VCHR_TYPE_MASTER_pkey");

                entity.ToTable("ACC_VCHR_TYPE_MASTER");

                entity.Property(e => e.VchrTypeId)
                    .HasColumnName("VCHR_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Isautomatic)
                    .HasColumnName("ISAUTOMATIC")
                    .HasMaxLength(1);

                entity.Property(e => e.Isfixed)
                    .HasColumnName("ISFIXED")
                    .HasMaxLength(1);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AccWorkFundsDetail>(entity =>
            {
                entity.HasKey(e => e.FundDetailId)
                    .HasName("ACC_WORK_FUNDS_DETAIL_pkey");

                entity.ToTable("ACC_WORK_FUNDS_DETAIL");

                entity.HasIndex(e => e.ProviderId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.FundDetailId)
                    .HasColumnName("FUND_DETAIL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FundedAmt).HasColumnName("FUNDED_AMT");

                entity.Property(e => e.FundedPercent).HasColumnName("FUNDED_PERCENT");

                entity.Property(e => e.Isjanasaramdha).HasColumnName("ISJANASARAMDHA");

                entity.Property(e => e.Isownoffice).HasColumnName("ISOWNOFFICE");

                entity.Property(e => e.ProviderId).HasColumnName("PROVIDER_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AccWorkFundsDetail)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_ACC_PROVIDER_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccWorkFundsDetail)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_WORK_MASTER_ID");
            });

            modelBuilder.Entity<AccWorkMaster>(entity =>
            {
                entity.HasKey(e => e.WorkId)
                    .HasName("ACC_WORK_MASTER_pkey");

                entity.ToTable("ACC_WORK_MASTER");

                entity.Property(e => e.WorkId)
                    .HasColumnName("WORK_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgreementAmt).HasColumnName("AGREEMENT_AMT");

                entity.Property(e => e.AgreementDate)
                    .HasColumnName("AGREEMENT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AgreementExpiryDate)
                    .HasColumnName("AGREEMENT_EXPIRY_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AgreementParty)
                    .HasColumnName("AGREEMENT_PARTY")
                    .HasMaxLength(70);

                entity.Property(e => e.AgreementSigningPerson)
                    .HasColumnName("AGREEMENT_SIGNING_PERSON")
                    .HasMaxLength(70);

                entity.Property(e => e.BankGuaranteeAmt).HasColumnName("BANK_GUARANTEE_AMT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.CorrectedAmt).HasColumnName("CORRECTED_AMT");

                entity.Property(e => e.DeadlineDate)
                    .HasColumnName("DEADLINE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DepositAmt).HasColumnName("DEPOSIT_AMT");

                entity.Property(e => e.DepositReleaseDate)
                    .HasColumnName("DEPOSIT_RELEASE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DepositReleasedDate)
                    .HasColumnName("DEPOSIT_RELEASED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DepositsAccId).HasColumnName("DEPOSITS_ACC_ID");

                entity.Property(e => e.DepositsForfeitAccId).HasColumnName("DEPOSITS_FORFEIT_ACC_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EstimatedAmt).HasColumnName("ESTIMATED_AMT");

                entity.Property(e => e.FinalActualAmtTobePaid).HasColumnName("FINAL_ACTUAL_AMT_TOBE_PAID");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("IS_COMPLETED")
                    .HasMaxLength(1);

                entity.Property(e => e.IsKramagat)
                    .HasColumnName("IS_KRAMAGAT")
                    .HasMaxLength(1);

                entity.Property(e => e.MeasureBookNo)
                    .HasColumnName("MEASURE_BOOK_NO")
                    .HasMaxLength(70);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(90);

                entity.Property(e => e.PartyId).HasColumnName("PARTY_ID");

                entity.Property(e => e.PartyPersontypeid).HasColumnName("PARTY_PERSONTYPEID");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonPersontypeid).HasColumnName("PERSON_PERSONTYPEID");

                entity.Property(e => e.TotalActualCost).HasColumnName("TOTAL_ACTUAL_COST");

                entity.Property(e => e.TpNo)
                    .HasColumnName("TP_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.VariationAmt).HasColumnName("VARIATION_AMT");

                entity.Property(e => e.WardNo).HasColumnName("WARD_NO");

                entity.Property(e => e.WorkCompleteDate)
                    .HasColumnName("WORK_COMPLETE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.YojanaNaturId).HasColumnName("YOJANA_NATUR_ID");
            });

            modelBuilder.Entity<AccWorkPaymntTrans>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("ACC_WORK_PAYMNT_TRANS_pkey");

                entity.ToTable("ACC_WORK_PAYMNT_TRANS");

                entity.HasIndex(e => e.PersonTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.HasIndex(e => e.WorkId);

                entity.Property(e => e.TransId)
                    .HasColumnName("TRANS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillAmt).HasColumnName("BILL_AMT");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.IsOfLastYear)
                    .HasColumnName("IS_OF_LAST_YEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.PadadhikariId).HasColumnName("PADADHIKARI_ID");

                entity.Property(e => e.PaymentSlipId).HasColumnName("PAYMENT_SLIP_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.UcId).HasColumnName("UC_ID");

                entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.AccWorkPaymntTrans)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_PAYMENT_PERSON_TYP_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.AccWorkPaymntTrans)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_PAYMENT_VCHR_ID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.AccWorkPaymntTrans)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_PAYMENT_WORKID");
            });

            modelBuilder.Entity<Accode>(entity =>
            {
                entity.HasKey(e => e.Accode1)
                    .HasName("ACCODE_pkey");

                entity.ToTable("ACCODE");

                entity.Property(e => e.Accode1)
                    .HasColumnName("ACCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Grcode).HasColumnName("GRCODE");

                entity.Property(e => e.Isassigned)
                    .HasColumnName("ISASSIGNED")
                    .HasMaxLength(2);

                entity.Property(e => e.Isdollar)
                    .HasColumnName("ISDOLLAR")
                    .HasMaxLength(2);

                entity.Property(e => e.Localcode)
                    .HasColumnName("LOCALCODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Sbcode).HasColumnName("SBCODE");

                entity.Property(e => e.Trantype)
                    .HasColumnName("TRANTYPE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ApplicationConfiguration>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("APPLICATION_CONFIGURATION_pkey");

                entity.ToTable("APPLICATION_CONFIGURATION");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameConfig)
                    .HasColumnName("NAME_CONFIG")
                    .HasMaxLength(70);

                entity.Property(e => e.ValueConfig)
                    .HasColumnName("VALUE_CONFIG")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BankBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("BANK_BRANCH_pkey");

                entity.ToTable("BANK_BRANCH");

                entity.HasIndex(e => e.Bankid);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BRANCH_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("BRANCH_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.IsPermitted)
                    .HasColumnName("IS_PERMITTED")
                    .HasMaxLength(2);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(25);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankBranch)
                    .HasForeignKey(d => d.Bankid)
                    .HasConstraintName("FK_BANK_MSTR");
            });

            modelBuilder.Entity<Bankmaster>(entity =>
            {
                entity.HasKey(e => e.Bankid)
                    .HasName("BANKMASTER_pkey");

                entity.ToTable("BANKMASTER");

                entity.Property(e => e.Bankid)
                    .HasColumnName("BANKID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accountnumber)
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(25);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.Bankcode)
                    .HasColumnName("BANKCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Bankname).HasColumnName("BANKNAME");

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(50);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(200);

                entity.Property(e => e.Cycode)
                    .HasColumnName("CYCODE")
                    .HasMaxLength(200);

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(100);

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.FinancelInstituteId).HasColumnName("FINANCEL_INSTITUTE_ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(40);

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.Trancode)
                    .HasColumnName("TRANCODE")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Banktransactions>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("BANKTRANSACTIONS_pkey");

                entity.ToTable("BANKTRANSACTIONS");

                entity.HasIndex(e => e.DhrtiMasterId);

                entity.HasIndex(e => e.SubmoduleTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.ChequeTypeId).HasColumnName("CHEQUE_TYPE_ID");

                entity.Property(e => e.Cramount).HasColumnName("CRAMOUNT");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.DhrtiMasterId).HasColumnName("DHRTI_MASTER_ID");

                entity.Property(e => e.Dramount).HasColumnName("DRAMOUNT");

                entity.Property(e => e.ExpSlipId).HasColumnName("EXP_SLIP_ID");

                entity.Property(e => e.Incomeexptypeid).HasColumnName("INCOMEEXPTYPEID");

                entity.Property(e => e.Isoflastyear)
                    .HasColumnName("ISOFLASTYEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.Orderinpaymentslip).HasColumnName("ORDERINPAYMENTSLIP");

                entity.Property(e => e.Payeename).HasColumnName("PAYEENAME");

                entity.Property(e => e.PayeenameEng).HasColumnName("PAYEENAME_ENG");

                entity.Property(e => e.PaymentOrderNo)
                    .HasColumnName("PAYMENT_ORDER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.SubmoduleTypeId).HasColumnName("SUBMODULE_TYPE_ID");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.HasOne(d => d.DhrtiMaster)
                    .WithMany(p => p.Banktransactions)
                    .HasForeignKey(d => d.DhrtiMasterId)
                    .HasConstraintName("SYS_C004545");

                entity.HasOne(d => d.SubmoduleType)
                    .WithMany(p => p.Banktransactions)
                    .HasForeignKey(d => d.SubmoduleTypeId)
                    .HasConstraintName("SYS_C004319");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.Banktransactions)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_BANKTRAN_VCHR_ID");
            });

            modelBuilder.Entity<BudjetSource>(entity =>
            {
                entity.ToTable("BUDJET_SOURCE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BudjetSubHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BUDJET_SUB_HEAD");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(70);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MinistryCode)
                    .HasColumnName("MINISTRY_CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.ParentCode).HasColumnName("PARENT_CODE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BusinessmasterHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BUSINESSMASTER_HISTORY");

                entity.Property(e => e.AddDate).HasColumnName("ADD_DATE");

                entity.Property(e => e.BizId).HasColumnName("BIZ_ID");

                entity.Property(e => e.Businessgroupid).HasColumnName("BUSINESSGROUPID");

                entity.Property(e => e.ComputerName)
                    .HasColumnName("COMPUTER_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DataStatus)
                    .HasColumnName("DATA_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.TranTime)
                    .HasColumnName("TRAN_TIME")
                    .HasMaxLength(20);

                entity.Property(e => e.WindowsUser)
                    .HasColumnName("WINDOWS_USER")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Cashtransaction>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("CASHTRANSACTION_pkey");

                entity.ToTable("CASHTRANSACTION");

                entity.HasIndex(e => e.DhrtiMasterId);

                entity.HasIndex(e => e.SubmoduleTypeId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.Cramount).HasColumnName("CRAMOUNT");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.DhrtiMasterId).HasColumnName("DHRTI_MASTER_ID");

                entity.Property(e => e.Dramount).HasColumnName("DRAMOUNT");

                entity.Property(e => e.ExpSlipId).HasColumnName("EXP_SLIP_ID");

                entity.Property(e => e.Incomeexptypeid).HasColumnName("INCOMEEXPTYPEID");

                entity.Property(e => e.Isoflastyear)
                    .HasColumnName("ISOFLASTYEAR")
                    .HasMaxLength(1);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(2);

                entity.Property(e => e.SubmoduleTypeId).HasColumnName("SUBMODULE_TYPE_ID");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.HasOne(d => d.DhrtiMaster)
                    .WithMany(p => p.Cashtransaction)
                    .HasForeignKey(d => d.DhrtiMasterId)
                    .HasConstraintName("SYS_C004544");

                entity.HasOne(d => d.SubmoduleType)
                    .WithMany(p => p.Cashtransaction)
                    .HasForeignKey(d => d.SubmoduleTypeId)
                    .HasConstraintName("SYS_C004318");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.Cashtransaction)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_CASHTRAN_VCHR_ID");
            });

            modelBuilder.Entity<Celedger20682069>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CELEDGER20682069");

                entity.Property(e => e.Calculatedvalue).HasColumnName("CALCULATEDVALUE");

                entity.Property(e => e.Constructionid).HasColumnName("CONSTRUCTIONID");

                entity.Property(e => e.Constructiontypeid).HasColumnName("CONSTRUCTIONTYPEID");

                entity.Property(e => e.Deppercent).HasColumnName("DEPPERCENT");

                entity.Property(e => e.Depreciationamount).HasColumnName("DEPRECIATIONAMOUNT");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Netcalculatedvalue).HasColumnName("NETCALCULATEDVALUE");

                entity.Property(e => e.Noncompletionreasonid).HasColumnName("NONCOMPLETIONREASONID");

                entity.Property(e => e.Noncompletionreasons)
                    .HasColumnName("NONCOMPLETIONREASONS")
                    .HasMaxLength(90);

                entity.Property(e => e.Otherminusinevaluations).HasColumnName("OTHERMINUSINEVALUATIONS");

                entity.Property(e => e.Otherplusinevaluations).HasColumnName("OTHERPLUSINEVALUATIONS");

                entity.Property(e => e.Otherplusminusdescriptions)
                    .HasColumnName("OTHERPLUSMINUSDESCRIPTIONS")
                    .HasMaxLength(90);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Spacemeasuringunit).HasColumnName("SPACEMEASURINGUNIT");

                entity.Property(e => e.Talanumber).HasColumnName("TALANUMBER");

                entity.Property(e => e.Taxed).HasColumnName("TAXED");

                entity.Property(e => e.Totalarea).HasColumnName("TOTALAREA");

                entity.Property(e => e.Vsdateofmade)
                    .HasColumnName("VSDATEOFMADE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Collectioncounters>(entity =>
            {
                entity.HasKey(e => e.Counterid)
                    .HasName("COLLECTIONCOUNTERS_pkey");

                entity.ToTable("COLLECTIONCOUNTERS");

                entity.Property(e => e.Counterid)
                    .HasColumnName("COUNTERID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CmptrName)
                    .HasColumnName("CMPTR_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Counterheadid).HasColumnName("COUNTERHEADID");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50);

                entity.Property(e => e.Macaddress)
                    .HasColumnName("MACADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Specialnotes)
                    .HasColumnName("SPECIALNOTES")
                    .HasMaxLength(90);

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");
            });

            modelBuilder.Entity<Constantvalues>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONSTANTVALUES");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Strvalue).HasColumnName("STRVALUE");

                entity.Property(e => e.Varname)
                    .HasColumnName("VARNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("CONTACTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COUNTRY");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Ddc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DDC");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DevRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEV_REGION");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DISTRICT");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.Zoneid).HasColumnName("ZONEID");
            });

            modelBuilder.Entity<EmpGrp>(entity =>
            {
                entity.ToTable("EMP_GRP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(80);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Firebrigadestate>(entity =>
            {
                entity.ToTable("FIREBRIGADESTATE");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Minimumservicecharge).HasColumnName("MINIMUMSERVICECHARGE");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Servicechargerate).HasColumnName("SERVICECHARGERATE");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Firebrigadestate)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_FIREBRIG_ACC_ID");
            });

            modelBuilder.Entity<Fiscalyears>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FISCALYEARS");

                entity.Property(e => e.Datefrom)
                    .HasColumnName("DATEFROM")
                    .HasMaxLength(10);

                entity.Property(e => e.Dateto)
                    .HasColumnName("DATETO")
                    .HasMaxLength(10);

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Sn).HasColumnName("SN");
            });

            modelBuilder.Entity<Fywiserentdarrate>(entity =>
            {
                entity.ToTable("FYWISERENTDARRATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Ratename)
                    .HasColumnName("RATENAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RentPer).HasColumnName("RENT_PER");

                entity.Property(e => e.RentTypeid).HasColumnName("RENT_TYPEID");
            });

            modelBuilder.Entity<FywisesanitationRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FYWISESANITATION_RATE");

                entity.Property(e => e.AreaUpto).HasColumnName("AREA_UPTO");

                entity.Property(e => e.EachAreaRate).HasColumnName("EACH_AREA_RATE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ForEachArea).HasColumnName("FOR_EACH_AREA");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Ratename).HasColumnName("RATENAME");

                entity.Property(e => e.RoadTypeid).HasColumnName("ROAD_TYPEID");

                entity.Property(e => e.Subgroupid).HasColumnName("SUBGROUPID");
            });
             

            modelBuilder.Entity<Incomebilldetails>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("INCOMEBILLDETAILS_pkey");

                entity.ToTable("INCOMEBILLDETAILS");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BackupPersonid).HasColumnName("BACKUP_PERSONID");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderinbill).HasColumnName("ORDERINBILL");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasMaxLength(10);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(5);

                entity.Property(e => e.Taxaddtnlid).HasColumnName("TAXADDTNLID");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Incomebilldetails)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_INBILL_DETL_ACC_ID");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.Incomebilldetails)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_INBILL_DET_VCHR_ID");
            });

            modelBuilder.Entity<IncomebilldetailsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INCOMEBILLDETAILS_HISTORY");

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.AddDate).HasColumnName("ADD_DATE");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BackupPersonid).HasColumnName("BACKUP_PERSONID");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.ComputerName)
                    .HasColumnName("COMPUTER_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.DataStatus)
                    .HasColumnName("DATA_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderinbill).HasColumnName("ORDERINBILL");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasMaxLength(10);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.SnIncomebilldtl).HasColumnName("SN_INCOMEBILLDTL");

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(5);

                entity.Property(e => e.Taxaddtnlid).HasColumnName("TAXADDTNLID");

                entity.Property(e => e.TranTime)
                    .HasColumnName("TRAN_TIME")
                    .HasMaxLength(20);

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.Vrno).HasColumnName("VRNO");

                entity.Property(e => e.WindowsUser)
                    .HasColumnName("WINDOWS_USER")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Incomebillmaster>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("INCOMEBILLMASTER_pkey");

                entity.ToTable("INCOMEBILLMASTER");

                entity.HasIndex(e => e.Billtypeid);

                entity.HasIndex(e => e.SubModuleId);

                entity.HasIndex(e => e.VchrId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.BackupPersonid).HasColumnName("BACKUP_PERSONID");

                entity.Property(e => e.Bankamount).HasColumnName("BANKAMOUNT");

                entity.Property(e => e.BillNoManual)
                    .HasColumnName("BILL_NO_MANUAL")
                    .HasMaxLength(25);

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.Billtypeid).HasColumnName("BILLTYPEID");

                entity.Property(e => e.CancelDate)
                    .HasColumnName("CANCEL_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CancelReason)
                    .HasColumnName("CANCEL_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.Cashamount).HasColumnName("CASHAMOUNT");

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasMaxLength(10);

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.Property(e => e.Taxincometype)
                    .HasColumnName("TAXINCOMETYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");

                entity.Property(e => e.WardNo).HasColumnName("WARD_NO");

                entity.HasOne(d => d.Billtype)
                    .WithMany(p => p.Incomebillmaster)
                    .HasForeignKey(d => d.Billtypeid)
                    .HasConstraintName("SYS_C004390");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.Incomebillmaster)
                    .HasForeignKey(d => d.SubModuleId)
                    .HasConstraintName("SYS_C004316");

                entity.HasOne(d => d.Vchr)
                    .WithMany(p => p.Incomebillmaster)
                    .HasForeignKey(d => d.VchrId)
                    .HasConstraintName("FK_INBILL_MAST_VCHR_ID");
            });

            modelBuilder.Entity<InvApplicantRate>(entity =>
            {
                entity.ToTable("INV_APPLICANT_RATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Applicantid).HasColumnName("APPLICANTID");

                entity.Property(e => e.ItemDetailId).HasColumnName("ITEM_DETAIL_ID");
            });

            modelBuilder.Entity<InvBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("INV_BRAND_pkey");

                entity.ToTable("INV_BRAND");

                entity.Property(e => e.BrandId)
                    .HasColumnName("BRAND_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvDeplist>(entity =>
            {
                entity.ToTable("INV_DEPLIST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.DeductAmt).HasColumnName("DEDUCT_AMT");

                entity.Property(e => e.DepreAmt).HasColumnName("DEPRE_AMT");

                entity.Property(e => e.DepreDuraton).HasColumnName("DEPRE_DURATON");

                entity.Property(e => e.DeprePer).HasColumnName("DEPRE_PER");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.MaxDepreAmt).HasColumnName("MAX_DEPRE_AMT");

                entity.Property(e => e.MinDepreAmt).HasColumnName("MIN_DEPRE_AMT");

                entity.Property(e => e.NetAmt).HasColumnName("NET_AMT");

                entity.Property(e => e.PurchaseAmt).HasColumnName("PURCHASE_AMT");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("PURCHASE_DATE")
                    .HasMaxLength(15);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");
            });

            modelBuilder.Entity<InvDepreciation>(entity =>
            {
                entity.ToTable("INV_DEPRECIATION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.DeprePer).HasColumnName("DEPRE_PER");

                entity.Property(e => e.DepreRate).HasColumnName("DEPRE_RATE");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.OrginalRate).HasColumnName("ORGINAL_RATE");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");
            });

            modelBuilder.Entity<InvDept>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("INV_DEPT_pkey");

                entity.ToTable("INV_DEPT");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DEPT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("OFFICE_ID");
            });

            modelBuilder.Entity<InvGoodsAdjust>(entity =>
            {
                entity.ToTable("INV_GOODS_ADJUST");

                entity.HasIndex(e => e.AcceptBy);

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.PrepBy);

                entity.HasIndex(e => e.SpecId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDtEng).HasColumnName("ACCEPT_DT_ENG");

                entity.Property(e => e.AcceptDtNp)
                    .HasColumnName("ACCEPT_DT_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.AdjDtEng).HasColumnName("ADJ_DT_ENG");

                entity.Property(e => e.AdjDtNp)
                    .HasColumnName("ADJ_DT_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.AdjQty).HasColumnName("ADJ_QTY");

                entity.Property(e => e.AdjTypeId).HasColumnName("ADJ_TYPE_ID");

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.BudgetYear)
                    .HasColumnName("BUDGET_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.GdAdjId)
                    .IsRequired()
                    .HasColumnName("GD_ADJ_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemAdjRate).HasColumnName("ITEM_ADJ_RATE");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemType).HasColumnName("ITEM_TYPE");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDtEng).HasColumnName("PREP_DT_ENG");

                entity.Property(e => e.PrepDtNp)
                    .HasColumnName("PREP_DT_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.HasOne(d => d.AcceptByNavigation)
                    .WithMany(p => p.InvGoodsAdjustAcceptByNavigation)
                    .HasForeignKey(d => d.AcceptBy)
                    .HasConstraintName("FK_ACCEPT_BY_GOOD_ADJ");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvGoodsAdjust)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_GOODS_ADJUST_BRAND_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvGoodsAdjust)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_GOODS_ADJUST_ITEM_ID");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvGoodsAdjustPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_PREP_BY_GOOD_ADJ");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvGoodsAdjust)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_GOODS_ADJUST_SPEC_ID");
            });

            modelBuilder.Entity<InvGoodsRecDetl>(entity =>
            {
                entity.ToTable("INV_GOODS_REC_DETL");

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.GoodsMasterId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.SpecId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DakhilaDtEng).HasColumnName("DAKHILA_DT_ENG");

                entity.Property(e => e.DiscAmt).HasColumnName("DISC_AMT");

                entity.Property(e => e.GoodsMasterId).HasColumnName("GOODS_MASTER_ID");

                entity.Property(e => e.Isnumbered)
                    .HasColumnName("ISNUMBERED")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.NetAmt).HasColumnName("NET_AMT");

                entity.Property(e => e.OtherExpencesAmt).HasColumnName("OTHER_EXPENCES_AMT");

                entity.Property(e => e.PurQty).HasColumnName("PUR_QTY");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.RecvQty).HasColumnName("RECV_QTY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.TaxPerUnitAmt).HasColumnName("TAX_PER_UNIT_AMT");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.WhetherTax)
                    .HasColumnName("WHETHER_TAX")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvGoodsRecDetl)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_GOODS_BRAND_ID");

                entity.HasOne(d => d.GoodsMaster)
                    .WithMany(p => p.InvGoodsRecDetl)
                    .HasForeignKey(d => d.GoodsMasterId)
                    .HasConstraintName("FK_GOODS_DTL_MASTERID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvGoodsRecDetl)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_GOODS_ITEM_ID");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvGoodsRecDetl)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_GOODS_SPEC_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.InvGoodsRecDetl)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_GOODS_UNIT_ID");
            });

            modelBuilder.Entity<InvGoodsRecMast>(entity =>
            {
                entity.ToTable("INV_GOODS_REC_MAST");

                entity.HasIndex(e => e.AcceptBy);

                entity.HasIndex(e => e.CheckBy);

                entity.HasIndex(e => e.PrepBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDt)
                    .HasColumnName("ACCEPT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.AcceptDtEng).HasColumnName("ACCEPT_DT_ENG");

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.CheckDt)
                    .HasColumnName("CHECK_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckDtEng).HasColumnName("CHECK_DT_ENG");

                entity.Property(e => e.DakhilaDt)
                    .HasColumnName("DAKHILA_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.DakhilaDtEng).HasColumnName("DAKHILA_DT_ENG");

                entity.Property(e => e.DakhilaId)
                    .IsRequired()
                    .HasColumnName("DAKHILA_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.DetailsEng)
                    .HasColumnName("DETAILS_ENG")
                    .HasMaxLength(200);

                entity.Property(e => e.DetailsNep)
                    .HasColumnName("DETAILS_NEP")
                    .HasMaxLength(200);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.InvBillNo)
                    .HasColumnName("INV_BILL_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.InvDate)
                    .HasColumnName("INV_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InvDateEng).HasColumnName("INV_DATE_ENG");

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDt)
                    .HasColumnName("PREP_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepDtEng).HasColumnName("PREP_DT_ENG");

                entity.Property(e => e.PurMasterId).HasColumnName("PUR_MASTER_ID");

                entity.Property(e => e.RepairId).HasColumnName("REPAIR_ID");

                entity.Property(e => e.WarehouseId).HasColumnName("WAREHOUSE_ID");

                entity.HasOne(d => d.AcceptByNavigation)
                    .WithMany(p => p.InvGoodsRecMastAcceptByNavigation)
                    .HasForeignKey(d => d.AcceptBy)
                    .HasConstraintName("FK_ACCEPT_BY_GOOD_EMP");

                entity.HasOne(d => d.CheckByNavigation)
                    .WithMany(p => p.InvGoodsRecMastCheckByNavigation)
                    .HasForeignKey(d => d.CheckBy)
                    .HasConstraintName("FK_CHECK_BY_GOOD_EMP");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvGoodsRecMastPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_PREP_BY_GOOD_EMP");
            });

            modelBuilder.Entity<InvIncreaseDecrease>(entity =>
            {
                entity.ToTable("INV_INCREASE_DECREASE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(30);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.NumId).HasColumnName("NUM_ID");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("PURCHASE_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.ScapAmount).HasColumnName("SCAP_AMOUNT");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");
            });

            modelBuilder.Entity<InvIssueDakhila>(entity =>
            {
                entity.ToTable("INV_ISSUE_DAKHILA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.IssuMasterId).HasColumnName("ISSU_MASTER_ID");

                entity.Property(e => e.IssueDetailId).HasColumnName("ISSUE_DETAIL_ID");

                entity.Property(e => e.IssueNo).HasColumnName("ISSUE_NO");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");
            });

            modelBuilder.Entity<InvIssueDetail>(entity =>
            {
                entity.ToTable("INV_ISSUE_DETAIL");

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ItemType);

                entity.HasIndex(e => e.SpecId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("DELIVERY_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.IssueDt)
                    .HasColumnName("ISSUE_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueDtEng).HasColumnName("ISSUE_DT_ENG");

                entity.Property(e => e.IssueMastId).HasColumnName("ISSUE_MAST_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemIssueNo).HasColumnName("ITEM_ISSUE_NO");

                entity.Property(e => e.ItemReqNo).HasColumnName("ITEM_REQ_NO");

                entity.Property(e => e.ItemType).HasColumnName("ITEM_TYPE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvIssueDetail)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_INV_ISS_DTL_BRAND_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvIssueDetail)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_ISS_DTL_ITEM_ID");

                entity.HasOne(d => d.ItemTypeNavigation)
                    .WithMany(p => p.InvIssueDetail)
                    .HasForeignKey(d => d.ItemType)
                    .HasConstraintName("FK_INV_ISS_DTL_ITEM_TYPE");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvIssueDetail)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_INV_ISS_DTL_SPEC_ID");
            });

            modelBuilder.Entity<InvIssueMaster>(entity =>
            {
                entity.ToTable("INV_ISSUE_MASTER");

                entity.HasIndex(e => e.AcceptBy);

                entity.HasIndex(e => e.CheckBy);

                entity.HasIndex(e => e.IssueBy);

                entity.HasIndex(e => e.PrepBy);

                entity.HasIndex(e => e.RequestId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDt)
                    .HasColumnName("ACCEPT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.BudgetYear)
                    .HasColumnName("BUDGET_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.CheckDt)
                    .HasColumnName("CHECK_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.HoName)
                    .HasColumnName("HO_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.HoPost)
                    .HasColumnName("HO_POST")
                    .HasMaxLength(30);

                entity.Property(e => e.IssueBy).HasColumnName("ISSUE_BY");

                entity.Property(e => e.IssueByCat)
                    .HasColumnName("ISSUE_BY_CAT")
                    .HasMaxLength(30);

                entity.Property(e => e.IssueDt)
                    .HasColumnName("ISSUE_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueNo)
                    .IsRequired()
                    .HasColumnName("ISSUE_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueReceive).HasColumnName("ISSUE_RECEIVE");

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDt)
                    .HasColumnName("PREP_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.ReceiveEmpId).HasColumnName("RECEIVE_EMP_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestId).HasColumnName("REQUEST_ID");

                entity.Property(e => e.TransferDecisionDate)
                    .HasColumnName("TRANSFER_DECISION_DATE")
                    .HasMaxLength(12);

                entity.Property(e => e.TransferDecisionNo)
                    .HasColumnName("TRANSFER_DECISION_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.AcceptByNavigation)
                    .WithMany(p => p.InvIssueMasterAcceptByNavigation)
                    .HasForeignKey(d => d.AcceptBy)
                    .HasConstraintName("FK_ISS_MAST_ACCEPT_BY");

                entity.HasOne(d => d.CheckByNavigation)
                    .WithMany(p => p.InvIssueMasterCheckByNavigation)
                    .HasForeignKey(d => d.CheckBy)
                    .HasConstraintName("FK_ISS_MAST_CHECK_BY");

                entity.HasOne(d => d.IssueByNavigation)
                    .WithMany(p => p.InvIssueMasterIssueByNavigation)
                    .HasForeignKey(d => d.IssueBy)
                    .HasConstraintName("FK_ISS_MAST_ISSUE_BY");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvIssueMasterPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_ISS_MAST_PREP_BY");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.InvIssueMaster)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_ISS_MAST_REQUEST_ID");
            });

            modelBuilder.Entity<InvItemAdjType>(entity =>
            {
                entity.ToTable("INV_ITEM_ADJ_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddSub)
                    .HasColumnName("ADD_SUB")
                    .HasMaxLength(15);

                entity.Property(e => e.AdjType)
                    .HasColumnName("ADJ_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvItemCategory>(entity =>
            {
                entity.ToTable("INV_ITEM_CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.DepreciationMax).HasColumnName("DEPRECIATION_MAX");

                entity.Property(e => e.DepreciationMin).HasColumnName("DEPRECIATION_MIN");

                entity.Property(e => e.DepreciationPer).HasColumnName("DEPRECIATION_PER");

                entity.Property(e => e.GrpLevel).HasColumnName("GRP_LEVEL");

                entity.Property(e => e.IsHeader).HasColumnName("IS_HEADER");

                entity.Property(e => e.Isexp).HasColumnName("ISEXP");

                entity.Property(e => e.Islast).HasColumnName("ISLAST");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Maxl).HasColumnName("MAXL");

                entity.Property(e => e.Minl).HasColumnName("MINL");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.Rmaxl).HasColumnName("RMAXL");

                entity.Property(e => e.Rminl).HasColumnName("RMINL");

                entity.Property(e => e.Unit).HasColumnName("UNIT");
            });

            modelBuilder.Entity<InvItemDetails>(entity =>
            {
                entity.HasKey(e => e.ItemDtlId)
                    .HasName("INV_ITEM_DETAILS_pkey");

                entity.ToTable("INV_ITEM_DETAILS");

                entity.HasIndex(e => e.AcceptBy);

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.CheckBy);

                entity.HasIndex(e => e.DakhilaId);

                entity.HasIndex(e => e.GdAdjId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.PrepBy);

                entity.HasIndex(e => e.SpecId);

                entity.Property(e => e.ItemDtlId)
                    .HasColumnName("ITEM_DTL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDt)
                    .HasColumnName("ACCEPT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.AdjType).HasColumnName("ADJ_TYPE");

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.BudgetYear)
                    .HasColumnName("BUDGET_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ChasisNo)
                    .HasColumnName("CHASIS_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.CheckDt)
                    .HasColumnName("CHECK_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.DakhilaId).HasColumnName("DAKHILA_ID");

                entity.Property(e => e.EngineNo)
                    .HasColumnName("ENGINE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.EntryDt)
                    .HasColumnName("ENTRY_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.GdAdjId).HasColumnName("GD_ADJ_ID");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("ISSUE_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemRate).HasColumnName("ITEM_RATE");

                entity.Property(e => e.ItemStatus)
                    .HasColumnName("ITEM_STATUS")
                    .HasMaxLength(10);

                entity.Property(e => e.LilamDt)
                    .HasColumnName("LILAM_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.LilamId).HasColumnName("LILAM_ID");

                entity.Property(e => e.ModelNo)
                    .HasColumnName("MODEL_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDt)
                    .HasColumnName("PREP_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RegNo)
                    .HasColumnName("REG_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.RelQty).HasColumnName("REL_QTY");

                entity.Property(e => e.RelUnit)
                    .HasColumnName("REL_UNIT")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.StokRtDt)
                    .HasColumnName("STOK_RT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.StokRtId).HasColumnName("STOK_RT_ID");

                entity.Property(e => e.Unit).HasColumnName("UNIT");

                entity.Property(e => e.WeightVeh).HasColumnName("WEIGHT_VEH");

                entity.HasOne(d => d.AcceptByNavigation)
                    .WithMany(p => p.InvItemDetailsAcceptByNavigation)
                    .HasForeignKey(d => d.AcceptBy)
                    .HasConstraintName("FK_ITEM_DETL_ACCEPT_BY");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvItemDetails)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEM_DETL_BRAND_ID");

                entity.HasOne(d => d.CheckByNavigation)
                    .WithMany(p => p.InvItemDetailsCheckByNavigation)
                    .HasForeignKey(d => d.CheckBy)
                    .HasConstraintName("FK_ITEM_DETL_CHECK_BY");

                entity.HasOne(d => d.Dakhila)
                    .WithMany(p => p.InvItemDetails)
                    .HasForeignKey(d => d.DakhilaId)
                    .HasConstraintName("FK_ITEM_DETL_DAKHILA_ID");

                entity.HasOne(d => d.GdAdj)
                    .WithMany(p => p.InvItemDetails)
                    .HasForeignKey(d => d.GdAdjId)
                    .HasConstraintName("FK_ITEM_DETL_GD_ADJ_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvItemDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEM_DETL_ITEM_ID");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvItemDetailsPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_ITEM_DETL_PREP_BY");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvItemDetails)
                    .HasForeignKey(d => d.SpecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEM_DETL_SPEC_ID");
            });

            modelBuilder.Entity<InvItemMst>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("INV_ITEM_MST_pkey");

                entity.ToTable("INV_ITEM_MST");

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ITEM_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AreaInsqFeets).HasColumnName("AREA_INSQ_FEETS");

                entity.Property(e => e.BudgetAccId).HasColumnName("BUDGET_ACC_ID");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Companyname)
                    .HasColumnName("COMPANYNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Constructontype)
                    .HasColumnName("CONSTRUCTONTYPE")
                    .HasMaxLength(150);

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Depmaxrate).HasColumnName("DEPMAXRATE");

                entity.Property(e => e.Depreciation).HasColumnName("DEPRECIATION");

                entity.Property(e => e.Gussage).HasColumnName("GUSSAGE");

                entity.Property(e => e.ItemMainClass).HasColumnName("ITEM_MAIN_CLASS");

                entity.Property(e => e.ItemNature).HasColumnName("ITEM_NATURE");

                entity.Property(e => e.ItemType).HasColumnName("ITEM_TYPE");

                entity.Property(e => e.KittaNo)
                    .HasColumnName("KITTA_NO")
                    .HasMaxLength(150);

                entity.Property(e => e.LandAreaInsqFeets).HasColumnName("LAND_AREA_INSQ_FEETS");

                entity.Property(e => e.LandLocation)
                    .HasColumnName("LAND_LOCATION")
                    .HasMaxLength(150);

                entity.Property(e => e.LandMarketRate).HasColumnName("LAND_MARKET_RATE");

                entity.Property(e => e.LandUnitRate).HasColumnName("LAND_UNIT_RATE");

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.Maxl).HasColumnName("MAXL");

                entity.Property(e => e.Minl).HasColumnName("MINL");

                entity.Property(e => e.Minrate).HasColumnName("MINRATE");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.Propertytype).HasColumnName("PROPERTYTYPE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.Rmaxl).HasColumnName("RMAXL");

                entity.Property(e => e.Rminl).HasColumnName("RMINL");

                entity.Property(e => e.Sizes).HasColumnName("SIZES");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.VehiclePartsId).HasColumnName("VEHICLE_PARTS_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.InvItemMst)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_ITEM_UNIT_ID");
            });

            modelBuilder.Entity<InvItemSpec>(entity =>
            {
                entity.HasKey(e => e.SpecId)
                    .HasName("INV_ITEM_SPEC_pkey");

                entity.ToTable("INV_ITEM_SPEC");

                entity.Property(e => e.SpecId)
                    .HasColumnName("SPEC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvItemStatuscheck>(entity =>
            {
                entity.ToTable("INV_ITEM_STATUSCHECK");

                entity.HasIndex(e => e.AcceptedBy);

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.PrepBy);

                entity.HasIndex(e => e.SpecId);

                entity.HasIndex(e => e.TallyBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedBy).HasColumnName("ACCEPTED_BY");

                entity.Property(e => e.AcceptedDate)
                    .HasColumnName("ACCEPTED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AcceptedDateEng).HasColumnName("ACCEPTED_DATE_ENG");

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.CheckQty).HasColumnName("CHECK_QTY");

                entity.Property(e => e.CheckStatus)
                    .HasColumnName("CHECK_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.CheckedDate)
                    .HasColumnName("CHECKED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckedDateEng).HasColumnName("CHECKED_DATE_ENG");

                entity.Property(e => e.CountUpDown)
                    .HasColumnName("COUNT_UP_DOWN")
                    .HasMaxLength(2);

                entity.Property(e => e.CountYesNo)
                    .HasColumnName("COUNT_YES_NO")
                    .HasMaxLength(2);

                entity.Property(e => e.FisicalYear)
                    .HasColumnName("FISICAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.InspEdDate)
                    .HasColumnName("INSP_ED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InspEdDateEng).HasColumnName("INSP_ED_DATE_ENG");

                entity.Property(e => e.InspStDate)
                    .HasColumnName("INSP_ST_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InspStDateEng).HasColumnName("INSP_ST_DATE_ENG");

                entity.Property(e => e.InspectDate)
                    .HasColumnName("INSPECT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InspectDateEng).HasColumnName("INSPECT_DATE_ENG");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(2);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDate)
                    .HasColumnName("PREP_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepDateEng).HasColumnName("PREP_DATE_ENG");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.StkCurCount).HasColumnName("STK_CUR_COUNT");

                entity.Property(e => e.StkMstCount).HasColumnName("STK_MST_COUNT");

                entity.Property(e => e.TallyBy).HasColumnName("TALLY_BY");

                entity.Property(e => e.UpDownDetail)
                    .HasColumnName("UP_DOWN_DETAIL")
                    .HasMaxLength(30);

                entity.Property(e => e.UpDownNo).HasColumnName("UP_DOWN_NO");

                entity.HasOne(d => d.AcceptedByNavigation)
                    .WithMany(p => p.InvItemStatuscheckAcceptedByNavigation)
                    .HasForeignKey(d => d.AcceptedBy)
                    .HasConstraintName("FK_STATUSCHECK_ACCEPT_BY");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvItemStatuscheck)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_STATUSCHECK_BRAND_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvItemStatuscheck)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ITEM_STATUS_CHECK");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvItemStatuscheckPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_STATUSCHECK_PREP_BY");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvItemStatuscheck)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_STATUSCHECK_SPEC_ID");

                entity.HasOne(d => d.TallyByNavigation)
                    .WithMany(p => p.InvItemStatuscheckTallyByNavigation)
                    .HasForeignKey(d => d.TallyBy)
                    .HasConstraintName("FK_STATUSCHECK_CHECK_BY");
            });

            modelBuilder.Entity<InvLilamAppmaster>(entity =>
            {
                entity.ToTable("INV_LILAM_APPMASTER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Applydate)
                    .HasColumnName("APPLYDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Applyengdate).HasColumnName("APPLYENGDATE");

                entity.Property(e => e.Applylilamid).HasColumnName("APPLYLILAMID");

                entity.Property(e => e.Appno).HasColumnName("APPNO");

                entity.Property(e => e.Orgapplicantname)
                    .HasColumnName("ORGAPPLICANTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Orgapplicantpost)
                    .HasColumnName("ORGAPPLICANTPOST")
                    .HasMaxLength(50);

                entity.Property(e => e.Projid).HasColumnName("PROJID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<InvLilamDetail>(entity =>
            {
                entity.ToTable("INV_LILAM_DETAIL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.Dakhilaid).HasColumnName("DAKHILAID");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("DELIVERY_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.DepAmt).HasColumnName("DEP_AMT");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("ISSUE_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueDtEng).HasColumnName("ISSUE_DT_ENG");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemIssueNo).HasColumnName("ITEM_ISSUE_NO");

                entity.Property(e => e.ItemType).HasColumnName("ITEM_TYPE");

                entity.Property(e => e.LilamId).HasColumnName("LILAM_ID");

                entity.Property(e => e.Minimumrate).HasColumnName("MINIMUMRATE");

                entity.Property(e => e.Nikashaid).HasColumnName("NIKASHAID");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.TotalInStock).HasColumnName("TOTAL_IN_STOCK");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");
            });

            modelBuilder.Entity<InvLilamMast>(entity =>
            {
                entity.ToTable("INV_LILAM_MAST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDt)
                    .HasColumnName("ACCEPT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.AcceptDtEng).HasColumnName("ACCEPT_DT_ENG");

                entity.Property(e => e.AcceptPercent).HasColumnName("ACCEPT_PERCENT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.CheckDt)
                    .HasColumnName("CHECK_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckDtEng).HasColumnName("CHECK_DT_ENG");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FiscalyearChukta)
                    .HasColumnName("FISCALYEAR_CHUKTA")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueBy).HasColumnName("ISSUE_BY");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("ISSUE_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.IssueDtEng).HasColumnName("ISSUE_DT_ENG");

                entity.Property(e => e.LilamNo)
                    .IsRequired()
                    .HasColumnName("LILAM_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Lilamtype).HasColumnName("LILAMTYPE");

                entity.Property(e => e.NewspaperName)
                    .HasColumnName("NEWSPAPER_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Pageno)
                    .HasColumnName("PAGENO")
                    .HasMaxLength(200);

                entity.Property(e => e.PernewsRate).HasColumnName("PERNEWS_RATE");

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDt)
                    .HasColumnName("PREP_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepDtEng).HasColumnName("PREP_DT_ENG");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("PUBLISH_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiveBy).HasColumnName("RECEIVE_BY");

                entity.Property(e => e.ReceivePersonName)
                    .HasColumnName("RECEIVE_PERSON_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.RecivePersonPost)
                    .HasColumnName("RECIVE_PERSON_POST")
                    .HasMaxLength(50);

                entity.Property(e => e.Registerno)
                    .HasColumnName("REGISTERNO")
                    .HasMaxLength(200);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.ValidDays).HasColumnName("VALID_DAYS");
            });

            modelBuilder.Entity<InvLilamRecList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_LILAM_REC_LIST");

                entity.Property(e => e.Applicantid).HasColumnName("APPLICANTID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RecDateNp)
                    .HasColumnName("REC_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<InvLilamappdetails>(entity =>
            {
                entity.ToTable("INV_LILAMAPPDETAILS");

                entity.HasIndex(e => e.Lilamappliid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Brandid).HasColumnName("BRANDID");

                entity.Property(e => e.Dakhilaid).HasColumnName("DAKHILAID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Lilamappliid).HasColumnName("LILAMAPPLIID");

                entity.Property(e => e.Lilamqty).HasColumnName("LILAMQTY");

                entity.Property(e => e.Lilamtotalamt).HasColumnName("LILAMTOTALAMT");

                entity.Property(e => e.Nikashaid).HasColumnName("NIKASHAID");

                entity.Property(e => e.Specid).HasColumnName("SPECID");

                entity.Property(e => e.Unitid).HasColumnName("UNITID");

                entity.HasOne(d => d.Lilamappli)
                    .WithMany(p => p.InvLilamappdetails)
                    .HasForeignKey(d => d.Lilamappliid)
                    .HasConstraintName("FK_INV_APPLIMASTID");
            });

            modelBuilder.Entity<InvOrgType>(entity =>
            {
                entity.ToTable("INV_ORG_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("INV_PROJECT_pkey");

                entity.ToTable("INV_PROJECT");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvPurMastPlan>(entity =>
            {
                entity.ToTable("INV_PUR_MAST_PLAN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgreementType)
                    .HasColumnName("AGREEMENT_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ApproxAmt).HasColumnName("APPROX_AMT");

                entity.Property(e => e.Budget1year).HasColumnName("BUDGET1YEAR");

                entity.Property(e => e.Budget2year).HasColumnName("BUDGET2YEAR");

                entity.Property(e => e.Budget3year).HasColumnName("BUDGET3YEAR");

                entity.Property(e => e.BudgetResource)
                    .HasColumnName("BUDGET_RESOURCE")
                    .HasMaxLength(30);

                entity.Property(e => e.BudgetYear)
                    .HasColumnName("BUDGET_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.PkgNo)
                    .HasColumnName("PKG_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.PurType)
                    .HasColumnName("PUR_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkEndDate)
                    .HasColumnName("WORK_END_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkEndDateAd).HasColumnName("WORK_END_DATE_AD");

                entity.Property(e => e.WorkStDate)
                    .HasColumnName("WORK_ST_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkStDateAd).HasColumnName("WORK_ST_DATE_AD");
            });

            modelBuilder.Entity<InvPurOrderDetl>(entity =>
            {
                entity.ToTable("INV_PUR_ORDER_DETL");

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ItemType);

                entity.HasIndex(e => e.PurMstId);

                entity.HasIndex(e => e.SpecId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.Isdakhila)
                    .HasColumnName("ISDAKHILA")
                    .HasMaxLength(1);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemRate).HasColumnName("ITEM_RATE");

                entity.Property(e => e.ItemType).HasColumnName("ITEM_TYPE");

                entity.Property(e => e.PurMstId).HasColumnName("PUR_MST_ID");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.TaxAmt).HasColumnName("TAX_AMT");

                entity.Property(e => e.TotalAmt).HasColumnName("TOTAL_AMT");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_PUR_ORDER_BRAND_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_PUR_ORDER_ITEM_ID");

                entity.HasOne(d => d.ItemTypeNavigation)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.ItemType)
                    .HasConstraintName("FK_PUR_ORDER_ITEM_TYPE");

                entity.HasOne(d => d.PurMst)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.PurMstId)
                    .HasConstraintName("FK_INV_PUR_MAST_ID");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_PUR_ORDER_SPEC_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.InvPurOrderDetl)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PUR_ORDER_UNIT_ID");
            });

            modelBuilder.Entity<InvPurOrderMast>(entity =>
            {
                entity.ToTable("INV_PUR_ORDER_MAST");

                entity.HasIndex(e => e.AcceptedBy);

                entity.HasIndex(e => e.CheckedBy);

                entity.HasIndex(e => e.PreparedBy);

                entity.HasIndex(e => e.SuppId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedBy).HasColumnName("ACCEPTED_BY");

                entity.Property(e => e.AcceptedDt)
                    .HasColumnName("ACCEPTED_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.AcceptedDtEng).HasColumnName("ACCEPTED_DT_ENG");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.BudgetYear)
                    .HasColumnName("BUDGET_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckedBy).HasColumnName("CHECKED_BY");

                entity.Property(e => e.CheckedDt)
                    .HasColumnName("CHECKED_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckedDtEng).HasColumnName("CHECKED_DT_ENG");

                entity.Property(e => e.CustomOrderNo)
                    .HasColumnName("CUSTOM_ORDER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.DakhilaLastEntryDt)
                    .HasColumnName("DAKHILA_LAST_ENTRY_DT")
                    .HasMaxLength(12);

                entity.Property(e => e.Isdakhila)
                    .HasColumnName("ISDAKHILA")
                    .HasMaxLength(1);

                entity.Property(e => e.LetterOrderNo)
                    .HasColumnName("LETTER_ORDER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.PreparedBy).HasColumnName("PREPARED_BY");

                entity.Property(e => e.PreparedDt)
                    .HasColumnName("PREPARED_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.PreparedDtEng).HasColumnName("PREPARED_DT_ENG");

                entity.Property(e => e.PurOrderDt)
                    .HasColumnName("PUR_ORDER_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.PurOrderDtEng).HasColumnName("PUR_ORDER_DT_ENG");

                entity.Property(e => e.PurOrderNo)
                    .HasColumnName("PUR_ORDER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.PurOrderType).HasColumnName("PUR_ORDER_TYPE");

                entity.Property(e => e.PurType).HasColumnName("PUR_TYPE");

                entity.Property(e => e.PurchaseDecisionDate)
                    .HasColumnName("PURCHASE_DECISION_DATE")
                    .HasMaxLength(12);

                entity.Property(e => e.PurchaseDecisionNo)
                    .HasColumnName("PURCHASE_DECISION_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.RepairOrderNo)
                    .HasColumnName("REPAIR_ORDER_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ReqId).HasColumnName("REQ_ID");

                entity.Property(e => e.ReturnItemDt)
                    .HasColumnName("RETURN_ITEM_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnItemDtEng).HasColumnName("RETURN_ITEM_DT_ENG");

                entity.Property(e => e.SuppId).HasColumnName("SUPP_ID");

                entity.HasOne(d => d.AcceptedByNavigation)
                    .WithMany(p => p.InvPurOrderMastAcceptedByNavigation)
                    .HasForeignKey(d => d.AcceptedBy)
                    .HasConstraintName("FK_ACCEPTED_BY_USR");

                entity.HasOne(d => d.CheckedByNavigation)
                    .WithMany(p => p.InvPurOrderMastCheckedByNavigation)
                    .HasForeignKey(d => d.CheckedBy)
                    .HasConstraintName("FK_CHECKED_BY_USR");

                entity.HasOne(d => d.PreparedByNavigation)
                    .WithMany(p => p.InvPurOrderMastPreparedByNavigation)
                    .HasForeignKey(d => d.PreparedBy)
                    .HasConstraintName("FK_PREPARED_BY_USR");

                entity.HasOne(d => d.Supp)
                    .WithMany(p => p.InvPurOrderMast)
                    .HasForeignKey(d => d.SuppId)
                    .HasConstraintName("FK_SUPP_ID_SPPLIER");
            });

            modelBuilder.Entity<InvPurType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_PUR_TYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.NepEng)
                    .HasColumnName("NEP_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InvReqDetail>(entity =>
            {
                entity.ToTable("INV_REQ_DETAIL");

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.ReqMastId);

                entity.HasIndex(e => e.SpecId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqMastId).HasColumnName("REQ_MAST_ID");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InvReqDetail)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_IN_REQ_DETL_BRAND_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvReqDetail)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_IN_REQ_DETL_ITEM_ID");

                entity.HasOne(d => d.ReqMast)
                    .WithMany(p => p.InvReqDetail)
                    .HasForeignKey(d => d.ReqMastId)
                    .HasConstraintName("FK_IN_REQ_DETL_MASTER_ID");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.InvReqDetail)
                    .HasForeignKey(d => d.SpecId)
                    .HasConstraintName("FK_IN_REQ_DETL_SPEC_ID");
            });

            modelBuilder.Entity<InvRequisitionMast>(entity =>
            {
                entity.ToTable("INV_REQUISITION_MAST");

                entity.HasIndex(e => e.AcceptBy);

                entity.HasIndex(e => e.CheckBy);

                entity.HasIndex(e => e.ItemId);

                entity.HasIndex(e => e.PrepBy);

                entity.HasIndex(e => e.ProjId);

                entity.HasIndex(e => e.ReqBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptBy).HasColumnName("ACCEPT_BY");

                entity.Property(e => e.AcceptDt)
                    .HasColumnName("ACCEPT_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.AcceptDtEng).HasColumnName("ACCEPT_DT_ENG");

                entity.Property(e => e.CheckBy).HasColumnName("CHECK_BY");

                entity.Property(e => e.CheckDt)
                    .HasColumnName("CHECK_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckDtEng).HasColumnName("CHECK_DT_ENG");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.HandoverId).HasColumnName("HANDOVER_ID");

                entity.Property(e => e.HandoverRoomId).HasColumnName("HANDOVER_ROOM_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.MaintainItemId).HasColumnName("MAINTAIN_ITEM_ID");

                entity.Property(e => e.Orgstaffname)
                    .HasColumnName("ORGSTAFFNAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Orgstaffpost)
                    .HasColumnName("ORGSTAFFPOST")
                    .HasMaxLength(100);

                entity.Property(e => e.PrepBy).HasColumnName("PREP_BY");

                entity.Property(e => e.PrepDt)
                    .HasColumnName("PREP_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepDtEng).HasColumnName("PREP_DT_ENG");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.PurchaseGive)
                    .HasColumnName("PURCHASE_GIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.Reasion).HasColumnName("REASION");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqBy).HasColumnName("REQ_BY");

                entity.Property(e => e.ReqDateEng).HasColumnName("REQ_DATE_ENG");

                entity.Property(e => e.ReqDateNep)
                    .HasColumnName("REQ_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.ReqId)
                    .HasColumnName("REQ_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ReqType).HasColumnName("REQ_TYPE");

                entity.Property(e => e.StockGive)
                    .HasColumnName("STOCK_GIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.VehicleId).HasColumnName("VEHICLE_ID");

                entity.HasOne(d => d.AcceptByNavigation)
                    .WithMany(p => p.InvRequisitionMastAcceptByNavigation)
                    .HasForeignKey(d => d.AcceptBy)
                    .HasConstraintName("FK_REQ_ACCEPT_BY_EMP");

                entity.HasOne(d => d.CheckByNavigation)
                    .WithMany(p => p.InvRequisitionMastCheckByNavigation)
                    .HasForeignKey(d => d.CheckBy)
                    .HasConstraintName("FK_REQ_CHECK_BY_EMP");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvRequisitionMast)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_REQ_ITEM_ID");

                entity.HasOne(d => d.PrepByNavigation)
                    .WithMany(p => p.InvRequisitionMastPrepByNavigation)
                    .HasForeignKey(d => d.PrepBy)
                    .HasConstraintName("FK_REQ_PREP_BY_EMP");

                entity.HasOne(d => d.Proj)
                    .WithMany(p => p.InvRequisitionMast)
                    .HasForeignKey(d => d.ProjId)
                    .HasConstraintName("FK_REQ_PROJECT_ID");

                entity.HasOne(d => d.ReqByNavigation)
                    .WithMany(p => p.InvRequisitionMastReqByNavigation)
                    .HasForeignKey(d => d.ReqBy)
                    .HasConstraintName("FK_REQ_REQ_BY");
            });

            modelBuilder.Entity<InvRoomMst>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("INV_ROOM_MST_pkey");

                entity.ToTable("INV_ROOM_MST");

                entity.HasIndex(e => e.DeptId);

                entity.Property(e => e.RoomId)
                    .HasColumnName("ROOM_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlockNo)
                    .HasColumnName("BLOCK_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.DescEn)
                    .HasColumnName("DESC_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.DescNp)
                    .HasColumnName("DESC_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.FloorNo).HasColumnName("FLOOR_NO");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.InvRoomMst)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_ROOM_DEP_ID");
            });

            modelBuilder.Entity<InvStatusDetail>(entity =>
            {
                entity.ToTable("INV_STATUS_DETAIL");

                entity.HasIndex(e => e.Acceptby);

                entity.HasIndex(e => e.Checkedby);

                entity.HasIndex(e => e.Preby);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acceptby).HasColumnName("ACCEPTBY");

                entity.Property(e => e.Acceptvsdate)
                    .HasColumnName("ACCEPTVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.Checkedby).HasColumnName("CHECKEDBY");

                entity.Property(e => e.Checkvsdate)
                    .HasColumnName("CHECKVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemStatusId).HasColumnName("ITEM_STATUS_ID");

                entity.Property(e => e.MainId).HasColumnName("MAIN_ID");

                entity.Property(e => e.Preby).HasColumnName("PREBY");

                entity.Property(e => e.Prevsdate)
                    .HasColumnName("PREVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.Statusdatead).HasColumnName("STATUSDATEAD");

                entity.Property(e => e.Statusdatevs)
                    .HasColumnName("STATUSDATEVS")
                    .HasMaxLength(10);

                entity.Property(e => e.Totalqty).HasColumnName("TOTALQTY");

                entity.HasOne(d => d.AcceptbyNavigation)
                    .WithMany(p => p.InvStatusDetailAcceptbyNavigation)
                    .HasForeignKey(d => d.Acceptby)
                    .HasConstraintName("FK_INV_STADEL_ACCEPTBY");

                entity.HasOne(d => d.CheckedbyNavigation)
                    .WithMany(p => p.InvStatusDetailCheckedbyNavigation)
                    .HasForeignKey(d => d.Checkedby)
                    .HasConstraintName("FK_INV_STADEL_CHECKEDBY");

                entity.HasOne(d => d.PrebyNavigation)
                    .WithMany(p => p.InvStatusDetailPrebyNavigation)
                    .HasForeignKey(d => d.Preby)
                    .HasConstraintName("FK_INV_STADEL_PREBY");
            });

            modelBuilder.Entity<InvSupItmDet>(entity =>
            {
                entity.ToTable("INV_SUP_ITM_DET");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.SupId).HasColumnName("SUP_ID");
            });

            modelBuilder.Entity<InvSupplier>(entity =>
            {
                entity.HasKey(e => e.SupId)
                    .HasName("INV_SUPPLIER_pkey");

                entity.ToTable("INV_SUPPLIER");

                entity.Property(e => e.SupId)
                    .HasColumnName("SUP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyNameEn)
                    .HasColumnName("COMPANY_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyNameNp)
                    .HasColumnName("COMPANY_NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.DateAd).HasColumnName("DATE_AD");

                entity.Property(e => e.DateVs)
                    .HasColumnName("DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(30);

                entity.Property(e => e.IsSelected)
                    .HasColumnName("IS_SELECTED")
                    .HasMaxLength(5);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.OrgType)
                    .HasColumnName("ORG_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(15);

                entity.Property(e => e.RegNo)
                    .HasColumnName("REG_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.RegiType)
                    .HasColumnName("REGI_TYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.SupType)
                    .HasColumnName("SUP_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.TpinPanNo)
                    .HasColumnName("TPIN_PAN_NO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<InvSupplierFiscalyear>(entity =>
            {
                entity.ToTable("INV_SUPPLIER_FISCALYEAR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(15);

                entity.Property(e => e.SupId).HasColumnName("SUP_ID");
            });

            modelBuilder.Entity<InvTaxRate>(entity =>
            {
                entity.HasKey(e => e.TaxRateId)
                    .HasName("INV_TAX_RATE_pkey");

                entity.ToTable("INV_TAX_RATE");

                entity.Property(e => e.TaxRateId)
                    .HasColumnName("TAX_RATE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnName("TAX_RATE");
            });

            modelBuilder.Entity<InvTypeSetup>(entity =>
            {
                entity.ToTable("INV_TYPE_SETUP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescEn)
                    .HasColumnName("DESC_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.DescNp)
                    .IsRequired()
                    .HasColumnName("DESC_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");
            });

            modelBuilder.Entity<InvUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("INV_UNIT_pkey");

                entity.ToTable("INV_UNIT");

                entity.Property(e => e.UnitId)
                    .HasColumnName("UNIT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescEn)
                    .HasColumnName("DESC_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.DescNp)
                    .IsRequired()
                    .HasColumnName("DESC_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.MulFactor).HasColumnName("MUL_FACTOR");

                entity.Property(e => e.NoOfUnits).HasColumnName("NO_OF_UNITS");

                entity.Property(e => e.RelatedTo)
                    .HasColumnName("RELATED_TO")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<InvWarehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId)
                    .HasName("INV_WAREHOUSE_pkey");

                entity.ToTable("INV_WAREHOUSE");

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WAREHOUSE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvYrlyPurPlan>(entity =>
            {
                entity.ToTable("INV_YRLY_PUR_PLAN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgreementDtAd).HasColumnName("AGREEMENT_DT_AD");

                entity.Property(e => e.AgreementType)
                    .HasColumnName("AGREEMENT_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.AnlysisDsgnDtAd).HasColumnName("ANLYSIS_DSGN_DT_AD");

                entity.Property(e => e.ApproxAmt).HasColumnName("APPROX_AMT");

                entity.Property(e => e.AprxAmtAcptDate)
                    .HasColumnName("APRX_AMT_ACPT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AprxAmtAcptDtAd).HasColumnName("APRX_AMT_ACPT_DT_AD");

                entity.Property(e => e.FormEntryDate)
                    .HasColumnName("FORM_ENTRY_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.InfoPublishDate)
                    .HasColumnName("INFO_PUBLISH_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.PurType)
                    .HasColumnName("PUR_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.TendrAcceptDate)
                    .HasColumnName("TENDR_ACCEPT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.TendrAcceptDtAd).HasColumnName("TENDR_ACCEPT_DT_AD");

                entity.Property(e => e.TendrCallDtAd).HasColumnName("TENDR_CALL_DT_AD");

                entity.Property(e => e.TendrOpenDate)
                    .HasColumnName("TENDR_OPEN_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.TendrOpenDtAd).HasColumnName("TENDR_OPEN_DT_AD");

                entity.Property(e => e.TendrSaleDate)
                    .HasColumnName("TENDR_SALE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Wrk2FinDtAd).HasColumnName("WRK_2_FIN_DT_AD");

                entity.Property(e => e.WrkAcmplshDate)
                    .HasColumnName("WRK_ACMPLSH_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.WrkAcmplshDtAd).HasColumnName("WRK_ACMPLSH_DT_AD");

                entity.Property(e => e.WrkOrderDate)
                    .HasColumnName("WRK_ORDER_DATE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<IpttaxsummaryHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IPTTAXSUMMARY_HISTORY");

                entity.Property(e => e.AddDate).HasColumnName("ADD_DATE");

                entity.Property(e => e.Additionalcharges).HasColumnName("ADDITIONALCHARGES");

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.ComputerName)
                    .HasColumnName("COMPUTER_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DataStatus)
                    .HasColumnName("DATA_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Datepaid)
                    .HasColumnName("DATEPAID")
                    .HasMaxLength(10);

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Isthisfromrevenueaccount).HasColumnName("ISTHISFROMREVENUEACCOUNT");

                entity.Property(e => e.LastTaxPaidAmount).HasColumnName("LAST_TAX_PAID_AMOUNT");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.RemHlFineAmount).HasColumnName("REM_HL_FINE_AMOUNT");

                entity.Property(e => e.RemHlFineStatus)
                    .HasColumnName("REM_HL_FINE_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.RemHlPaidAmount).HasColumnName("REM_HL_PAID_AMOUNT");

                entity.Property(e => e.RemIptFineAmount).HasColumnName("REM_IPT_FINE_AMOUNT");

                entity.Property(e => e.RemIptFineStatus)
                    .HasColumnName("REM_IPT_FINE_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.RemIptPaidAmount).HasColumnName("REM_IPT_PAID_AMOUNT");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Specialnotes).HasColumnName("SPECIALNOTES");

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.Taxpaidamount).HasColumnName("TAXPAIDAMOUNT");

                entity.Property(e => e.TranTime)
                    .HasColumnName("TRAN_TIME")
                    .HasMaxLength(20);

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.WindowsUser)
                    .HasColumnName("WINDOWS_USER")
                    .HasMaxLength(100);

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<Issuedbills>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ISSUEDBILLS");

                entity.Property(e => e.Billnofrom)
                    .HasColumnName("BILLNOFROM")
                    .HasMaxLength(25);

                entity.Property(e => e.Billnoto)
                    .HasColumnName("BILLNOTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.Dateissued)
                    .HasColumnName("DATEISSUED")
                    .HasMaxLength(10);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Specialnotes)
                    .HasColumnName("SPECIALNOTES")
                    .HasMaxLength(90);

                entity.Property(e => e.Thelino).HasColumnName("THELINO");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Landmeasuringunits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LANDMEASURINGUNITS");

                entity.Property(e => e.Sqftperunit).HasColumnName("SQFTPERUNIT");

                entity.Property(e => e.Unitid).HasColumnName("UNITID");

                entity.Property(e => e.Unitname)
                    .HasColumnName("UNITNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Landsmultievaluationdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LANDSMULTIEVALUATIONDETAIL");

                entity.Property(e => e.Areainsqft).HasColumnName("AREAINSQFT");

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Kittanumber)
                    .HasColumnName("KITTANUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.Sn).HasColumnName("SN");
            });

            modelBuilder.Entity<Leledger20682069>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LELEDGER20682069");

                entity.Property(e => e.Appliedvalue).HasColumnName("APPLIEDVALUE");

                entity.Property(e => e.Calculatedvalue).HasColumnName("CALCULATEDVALUE");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Kittanumber)
                    .HasColumnName("KITTANUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.Landmeasuringunit).HasColumnName("LANDMEASURINGUNIT");

                entity.Property(e => e.Netcalculatedvalue).HasColumnName("NETCALCULATEDVALUE");

                entity.Property(e => e.Netevaluatingarea).HasColumnName("NETEVALUATINGAREA");

                entity.Property(e => e.Noncompletionreasonid).HasColumnName("NONCOMPLETIONREASONID");

                entity.Property(e => e.Noncompletionreasons)
                    .HasColumnName("NONCOMPLETIONREASONS")
                    .HasMaxLength(90);

                entity.Property(e => e.Nonevaluatedarea).HasColumnName("NONEVALUATEDAREA");

                entity.Property(e => e.Otherminusinevaluations).HasColumnName("OTHERMINUSINEVALUATIONS");

                entity.Property(e => e.Otherplusinevaluations).HasColumnName("OTHERPLUSINEVALUATIONS");

                entity.Property(e => e.Otherplusminusdescriptions)
                    .HasColumnName("OTHERPLUSMINUSDESCRIPTIONS")
                    .HasMaxLength(90);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.Selfdeclaredvalue).HasColumnName("SELFDECLAREDVALUE");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Taxed).HasColumnName("TAXED");

                entity.Property(e => e.Totalarea).HasColumnName("TOTALAREA");

                entity.Property(e => e.Trackid).HasColumnName("TRACKID");

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");
            });

            modelBuilder.Entity<MalpotLands>(entity =>
            {
                entity.ToTable("MALPOT_LANDS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnName("ADD_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.AddUserid).HasColumnName("ADD_USERID");

                entity.Property(e => e.Areainsqft).HasColumnName("AREAINSQFT");

                entity.Property(e => e.EditDate)
                    .HasColumnName("EDIT_DATE")
                    .HasMaxLength(30);

                entity.Property(e => e.EditUserid).HasColumnName("EDIT_USERID");

                entity.Property(e => e.Eid)
                    .HasColumnName("EID")
                    .HasMaxLength(200);

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.IsIpt).HasColumnName("IS_IPT");

                entity.Property(e => e.Kittanumber)
                    .HasColumnName("KITTANUMBER")
                    .HasMaxLength(200);

                entity.Property(e => e.Mothnumber)
                    .HasColumnName("MOTHNUMBER")
                    .HasMaxLength(200);

                entity.Property(e => e.Nonfunctionalareainsqft).HasColumnName("NONFUNCTIONALAREAINSQFT");

                entity.Property(e => e.NpFirstname)
                    .HasColumnName("NP_FIRSTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.NpLastname)
                    .HasColumnName("NP_LASTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Oldvdcid).HasColumnName("OLDVDCID");

                entity.Property(e => e.Oldwordno)
                    .HasColumnName("OLDWORDNO")
                    .HasMaxLength(100);

                entity.Property(e => e.Vdcid).HasColumnName("VDCID");

                entity.Property(e => e.Wordno).HasColumnName("WORDNO");
            });

            modelBuilder.Entity<MapAreaGndCov>(entity =>
            {
                entity.ToTable("MAP_AREA_GND_COV");

                entity.HasIndex(e => e.Regionid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.GroundCov).HasColumnName("GROUND_COV");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.MapAreaGndCov)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("FK_REGN_ID_AP_GND_COV");
            });

            modelBuilder.Entity<MapConstrctionKind>(entity =>
            {
                entity.ToTable("MAP_CONSTRCTION_KIND");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapDesignerDtl>(entity =>
            {
                entity.ToTable("MAP_DESIGNER_DTL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Class)
                    .HasColumnName("CLASS")
                    .HasMaxLength(1);

                entity.Property(e => e.DesignerName)
                    .HasColumnName("DESIGNER_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.EngcouncilregNo)
                    .HasColumnName("ENGCOUNCILREG_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.FirmName)
                    .HasColumnName("FIRM_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasColumnName("REG_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);

                entity.Property(e => e.StatusId)
                    .HasColumnName("STATUS_ID")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<MapDirection>(entity =>
            {
                entity.ToTable("MAP_DIRECTION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapDrainType>(entity =>
            {
                entity.ToTable("MAP_DRAIN_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapFloor>(entity =>
            {
                entity.ToTable("MAP_FLOOR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapHouseuseType>(entity =>
            {
                entity.ToTable("MAP_HOUSEUSE_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapHtstandard>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("MAP_HTSTANDARD_pkey");

                entity.ToTable("MAP_HTSTANDARD");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Distanceft).HasColumnName("DISTANCEFT");

                entity.Property(e => e.Kv).HasColumnName("KV");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MapIncomeType>(entity =>
            {
                entity.ToTable("MAP_INCOME_TYPE");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.MapIncomeType)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_MINCOME_TYPE_ACCID");
            });

            modelBuilder.Entity<MapLandOwnerType>(entity =>
            {
                entity.ToTable("MAP_LAND_OWNER_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapNeighbourType>(entity =>
            {
                entity.ToTable("MAP_NEIGHBOUR_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapRate>(entity =>
            {
                entity.ToTable("MAP_RATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepositeRatePermit).HasColumnName("DEPOSITE_RATE_PERMIT");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("ENTRY_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.RatePermit).HasColumnName("RATE_PERMIT");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<MapRegionFar>(entity =>
            {
                entity.ToTable("MAP_REGION_FAR");

                entity.HasIndex(e => e.Regionid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaFrom).HasColumnName("AREA_FROM");

                entity.Property(e => e.AreaTo).HasColumnName("AREA_TO");

                entity.Property(e => e.Far).HasColumnName("FAR");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.MapRegionFar)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("FK_REGIONID");
            });

            modelBuilder.Entity<MapRoofCnstrctType>(entity =>
            {
                entity.ToTable("MAP_ROOF_CNSTRCT_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapRoofType>(entity =>
            {
                entity.ToTable("MAP_ROOF_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .IsRequired()
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapSite>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("MAP_SITE_pkey");

                entity.ToTable("MAP_SITE");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Landshape).HasColumnName("LANDSHAPE");

                entity.Property(e => e.Permitid).HasColumnName("PERMITID");

                entity.Property(e => e.SideA).HasColumnName("SIDE_A");

                entity.Property(e => e.SideB).HasColumnName("SIDE_B");

                entity.Property(e => e.SideC).HasColumnName("SIDE_C");
            });

            modelBuilder.Entity<MapStdheightRw>(entity =>
            {
                entity.ToTable("MAP_STDHEIGHT_RW");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.HouseHeight).HasColumnName("HOUSE_HEIGHT");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);

                entity.Property(e => e.RoadWidth).HasColumnName("ROAD_WIDTH");
            });

            modelBuilder.Entity<MapStoreys>(entity =>
            {
                entity.ToTable("MAP_STOREYS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapStructureType>(entity =>
            {
                entity.ToTable("MAP_STRUCTURE_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MapZone>(entity =>
            {
                entity.ToTable("MAP_ZONE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Ministry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MINISTRY");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.District).HasColumnName("DISTRICT");

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(70);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.Vdc).HasColumnName("VDC");

                entity.Property(e => e.Zone).HasColumnName("ZONE");
            });

            modelBuilder.Entity<MinistryAccHead>(entity =>
            {
                entity.ToTable("MINISTRY_ACC_HEAD");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(70);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SubHeadId).HasColumnName("SUB_HEAD_ID");
            });

            modelBuilder.Entity<Nationalities>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NATIONALITIES");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(25);

                entity.Property(e => e.Nationalityid).HasColumnName("NATIONALITYID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NewPropertyTaxtable>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("NEW_PROPERTY_TAXTABLE_pkey");

                entity.ToTable("NEW_PROPERTY_TAXTABLE");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Frompropertyvalue).HasColumnName("FROMPROPERTYVALUE");

                entity.Property(e => e.Fromtaxamount).HasColumnName("FROMTAXAMOUNT");

                entity.Property(e => e.Ratesn).HasColumnName("RATESN");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(190);

                entity.Property(e => e.TaxPercent).HasColumnName("TAX_PERCENT");

                entity.Property(e => e.Topropertyvalue).HasColumnName("TOPROPERTYVALUE");

                entity.Property(e => e.Totaxamount).HasColumnName("TOTAXAMOUNT");
            });

            modelBuilder.Entity<OfficeType>(entity =>
            {
                entity.ToTable("OFFICE_TYPE");

                entity.Property(e => e.OfficeTypeId)
                    .HasColumnName("OFFICE_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfficeType1)
                    .IsRequired()
                    .HasColumnName("OFFICE_TYPE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<OrgBankAccount>(entity =>
            {
                entity.ToTable("ORG_BANK_ACCOUNT");

                entity.HasIndex(e => e.BankAccntTypeId);

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.OrgId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccName)
                    .HasColumnName("ACC_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.AccNo)
                    .HasColumnName("ACC_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccntTypeId).HasColumnName("BANK_ACCNT_TYPE_ID");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.HasOne(d => d.BankAccntType)
                    .WithMany(p => p.OrgBankAccount)
                    .HasForeignKey(d => d.BankAccntTypeId)
                    .HasConstraintName("FK_BANK_ACCNT_TYPE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OrgBankAccount)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BANK_BRANCH");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgBankAccount)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_ORG_MASTER");
            });

            modelBuilder.Entity<OrganizationTree>(entity =>
            {
                entity.ToTable("ORGANIZATION_TREE");

                entity.HasIndex(e => e.GeoRegion);

                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContainsDarbandi).HasColumnName("CONTAINS_DARBANDI");

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.GeoRegion).HasColumnName("GEO_REGION");

                entity.Property(e => e.GrpLevel).HasColumnName("GRP_LEVEL");

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.HasOne(d => d.GeoRegionNavigation)
                    .WithMany(p => p.OrganizationTree)
                    .HasForeignKey(d => d.GeoRegion)
                    .HasConstraintName("FK_ORG_GEO_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ORG_PARENT_ID");
            });

            modelBuilder.Entity<PaymentSlipMaster>(entity =>
            {
                entity.HasKey(e => e.PaymentSlipId)
                    .HasName("PAYMENT_SLIP_MASTER_pkey");

                entity.ToTable("PAYMENT_SLIP_MASTER");

                entity.Property(e => e.PaymentSlipId)
                    .HasColumnName("PAYMENT_SLIP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvClearedFromBank).HasColumnName("ADV_CLEARED_FROM_BANK");

                entity.Property(e => e.AdvClearedFromBill).HasColumnName("ADV_CLEARED_FROM_BILL");

                entity.Property(e => e.AdvClearedFromCash).HasColumnName("ADV_CLEARED_FROM_CASH");

                entity.Property(e => e.BillAmt).HasColumnName("BILL_AMT");

                entity.Property(e => e.CashPayment).HasColumnName("CASH_PAYMENT");

                entity.Property(e => e.ChequePayment).HasColumnName("CHEQUE_PAYMENT");

                entity.Property(e => e.ContractTaxDeduction).HasColumnName("CONTRACT_TAX_DEDUCTION");

                entity.Property(e => e.IncomeTaxDeduction).HasColumnName("INCOME_TAX_DEDUCTION");

                entity.Property(e => e.IsPeski)
                    .HasColumnName("IS_PESKI")
                    .HasMaxLength(1);

                entity.Property(e => e.LastYearsAdvDeduction).HasColumnName("LAST_YEARS_ADV_DEDUCTION");

                entity.Property(e => e.LyAdvClearedFromBank).HasColumnName("LY_ADV_CLEARED_FROM_BANK");

                entity.Property(e => e.LyAdvClearedFromBill).HasColumnName("LY_ADV_CLEARED_FROM_BILL");

                entity.Property(e => e.LyAdvClearedFromCash).HasColumnName("LY_ADV_CLEARED_FROM_CASH");

                entity.Property(e => e.OtherDeduction).HasColumnName("OTHER_DEDUCTION");

                entity.Property(e => e.PaymentDescription)
                    .HasColumnName("PAYMENT_DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.RetentionMoneyEduction).HasColumnName("RETENTION_MONEY_EDUCTION");

                entity.Property(e => e.TransactionTypeid).HasColumnName("TRANSACTION_TYPEID");

                entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");

                entity.Property(e => e.VatDeduction).HasColumnName("VAT_DEDUCTION");

                entity.Property(e => e.VrDate)
                    .HasColumnName("VR_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.VrNo).HasColumnName("VR_NO");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");
            });

            modelBuilder.Entity<PersonTypeMaster>(entity =>
            {
                entity.HasKey(e => e.PersonTypeId)
                    .HasName("PERSON_TYPE_MASTER_pkey");

                entity.ToTable("PERSON_TYPE_MASTER");

                entity.Property(e => e.PersonTypeId)
                    .HasColumnName("PERSON_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isfixed)
                    .HasColumnName("ISFIXED")
                    .HasMaxLength(1);

                entity.Property(e => e.NameEn).HasColumnName("NAME_EN");

                entity.Property(e => e.NameNp).HasColumnName("NAME_NP");
            });

            modelBuilder.Entity<PisAppointmentType>(entity =>
            {
                entity.ToTable("PIS_APPOINTMENT_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PisAttributes>(entity =>
            {
                entity.ToTable("PIS_ATTRIBUTES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(90);

                entity.Property(e => e.NameNep)
                    .HasColumnName("NAME_NEP")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<PisAwards>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_AWARDS_pkey");

                entity.ToTable("PIS_AWARDS");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LevelDesc)
                    .HasColumnName("LEVEL_DESC")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.RcvdDateAd).HasColumnName("RCVD_DATE_AD");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.RvcdDateVs)
                    .HasColumnName("RVCD_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisAwards)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_AWARDS_LOC_POST_ID");
            });

            modelBuilder.Entity<PisBankPayroll>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_BANK_PAYROLL_pkey");

                entity.ToTable("PIS_BANK_PAYROLL");

                entity.HasIndex(e => e.BankId);

                entity.HasIndex(e => e.EmpId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.BankFolio)
                    .HasColumnName("BANK_FOLIO")
                    .HasMaxLength(25);

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.PisBankPayroll)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_BNK_PYRL_BANK_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisBankPayroll)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_BNK_PYRL_EMP_ID");
            });

            modelBuilder.Entity<PisDarbandi>(entity =>
            {
                entity.HasKey(e => e.DarbandiId)
                    .HasName("PIS_DARBANDI_pkey");

                entity.ToTable("PIS_DARBANDI");

                entity.HasIndex(e => e.LocalPostId);

                entity.HasIndex(e => e.OfficeId);

                entity.HasIndex(e => e.PostId);

                entity.Property(e => e.DarbandiId)
                    .HasColumnName("DARBANDI_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NoOfPost).HasColumnName("NO_OF_POST");

                entity.Property(e => e.OfficeId).HasColumnName("OFFICE_ID");

                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                entity.Property(e => e.PostLevel).HasColumnName("POST_LEVEL");

                entity.Property(e => e.SewaSamuhaUpasamuha)
                    .HasColumnName("SEWA_SAMUHA_UPASAMUHA")
                    .HasMaxLength(100);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisDarbandi)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_DARBANDI_LOC_POST_ID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PisDarbandi)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_DARBANDI_OFFICE_ID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PisDarbandi)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_DARBANDI_POST_ID");
            });

            modelBuilder.Entity<PisDeletdFrmFulfildDarb>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_DELETD_FRM_FULFILD_DARB_pkey");

                entity.ToTable("PIS_DELETD_FRM_FULFILD_DARB");

                entity.HasIndex(e => e.FrmDarbandiId);

                entity.HasIndex(e => e.FrmOfficeId);

                entity.HasIndex(e => e.FrmSnInFd);

                entity.HasIndex(e => e.ToSnInFd);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FrmAppointmntType).HasColumnName("FRM_APPOINTMNT_TYPE");

                entity.Property(e => e.FrmDarbandiId).HasColumnName("FRM_DARBANDI_ID");

                entity.Property(e => e.FrmDateFulfilled)
                    .HasColumnName("FRM_DATE_FULFILLED")
                    .HasMaxLength(10);

                entity.Property(e => e.FrmOfficeId).HasColumnName("FRM_OFFICE_ID");

                entity.Property(e => e.FrmSnInFd).HasColumnName("FRM_SN_IN_FD");

                entity.Property(e => e.ToSnInFd).HasColumnName("TO_SN_IN_FD");

                entity.HasOne(d => d.FrmDarbandi)
                    .WithMany(p => p.PisDeletdFrmFulfildDarb)
                    .HasForeignKey(d => d.FrmDarbandiId)
                    .HasConstraintName("FK_DEL_FD_DARBANDI_ID");

                entity.HasOne(d => d.FrmOffice)
                    .WithMany(p => p.PisDeletdFrmFulfildDarb)
                    .HasForeignKey(d => d.FrmOfficeId)
                    .HasConstraintName("FK_DEL_FD_OFFICE_ID");

                entity.HasOne(d => d.FrmSnInFdNavigation)
                    .WithMany(p => p.PisDeletdFrmFulfildDarbFrmSnInFdNavigation)
                    .HasForeignKey(d => d.FrmSnInFd)
                    .HasConstraintName("FK_FROM_SN_IN_FD");

                entity.HasOne(d => d.ToSnInFdNavigation)
                    .WithMany(p => p.PisDeletdFrmFulfildDarbToSnInFdNavigation)
                    .HasForeignKey(d => d.ToSnInFd)
                    .HasConstraintName("FK_TO_SN_IN_FD");
            });

            modelBuilder.Entity<PisEduBoard>(entity =>
            {
                entity.ToTable("PIS_EDU_BOARD");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.NameEng)
                    .HasColumnName("NAME_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.NameNep)
                    .HasColumnName("NAME_NEP")
                    .HasMaxLength(100);

                entity.Property(e => e.Place)
                    .HasColumnName("PLACE")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<PisEduLevel>(entity =>
            {
                entity.HasKey(e => e.EduId)
                    .HasName("PIS_EDU_LEVEL_pkey");

                entity.ToTable("PIS_EDU_LEVEL");

                entity.Property(e => e.EduId)
                    .HasColumnName("EDU_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EduName)
                    .HasColumnName("EDU_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PisEducation>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EDUCATION_pkey");

                entity.ToTable("PIS_EDUCATION");

                entity.HasIndex(e => e.BoardId);

                entity.HasIndex(e => e.EduLevelId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.BoardId).HasColumnName("BOARD_ID");

                entity.Property(e => e.CompletionYrAd).HasColumnName("COMPLETION_YR_AD");

                entity.Property(e => e.CompletionYrVs)
                    .HasColumnName("COMPLETION_YR_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.Division)
                    .HasColumnName("DIVISION")
                    .HasMaxLength(25);

                entity.Property(e => e.EduLevelId).HasColumnName("EDU_LEVEL_ID");

                entity.Property(e => e.EduName)
                    .HasColumnName("EDU_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Institute)
                    .HasColumnName("INSTITUTE")
                    .HasMaxLength(70);

                entity.Property(e => e.MarksGrade).HasColumnName("MARKS_GRADE");

                entity.Property(e => e.MarksPercnt).HasColumnName("MARKS_PERCNT");

                entity.Property(e => e.Subjects)
                    .HasColumnName("SUBJECTS")
                    .HasMaxLength(100);

                entity.Property(e => e.ValidForEval).HasColumnName("VALID_FOR_EVAL");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.PisEducation)
                    .HasForeignKey(d => d.BoardId)
                    .HasConstraintName("FK_EDU_BRD");

                entity.HasOne(d => d.EduLevel)
                    .WithMany(p => p.PisEducation)
                    .HasForeignKey(d => d.EduLevelId)
                    .HasConstraintName("FK_EDU_LVL");
            });

            modelBuilder.Entity<PisEmpAdvDedDtl>(entity =>
            {
                entity.ToTable("PIS_EMP_ADV_DED_DTL");

                entity.HasIndex(e => e.EmpId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AmountCur).HasColumnName("AMOUNT_CUR");

                entity.Property(e => e.AmountPrev).HasColumnName("AMOUNT_PREV");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpAdvDedDtl)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_ADV_DED_EMP_ID");
            });

            modelBuilder.Entity<PisEmpBarga>(entity =>
            {
                entity.ToTable("PIS_EMP_BARGA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(25);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<PisEmpDep>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PIS_EMP_DEP_pkey");

                entity.ToTable("PIS_EMP_DEP");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DEPT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsntKattiAccId).HasColumnName("ABSNT_KATTI_ACC_ID");

                entity.Property(e => e.AddInsrnceAccId).HasColumnName("ADD_INSRNCE_ACC_ID");

                entity.Property(e => e.AddPfAccId).HasColumnName("ADD_PF_ACC_ID");

                entity.Property(e => e.AllowanceAccId).HasColumnName("ALLOWANCE_ACC_ID");

                entity.Property(e => e.BhattaAccId).HasColumnName("BHATTA_ACC_ID");

                entity.Property(e => e.BudgetSourceId).HasColumnName("BUDGET_SOURCE_ID");

                entity.Property(e => e.BudjetSourceId).HasColumnName("BUDJET_SOURCE_ID");

                entity.Property(e => e.CitAccId).HasColumnName("CIT_ACC_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.IncmeTaxAccId).HasColumnName("INCME_TAX_ACC_ID");

                entity.Property(e => e.LendPfDAccId).HasColumnName("LEND_PF_D_ACC_ID");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .IsRequired()
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.OthrKattiAccId).HasColumnName("OTHR_KATTI_ACC_ID");

                entity.Property(e => e.PeskiKattiAccId).HasColumnName("PESKI_KATTI_ACC_ID");

                entity.Property(e => e.SalaryAccId).HasColumnName("SALARY_ACC_ID");

                entity.Property(e => e.SapatiKattiAccId).HasColumnName("SAPATI_KATTI_ACC_ID");

                entity.Property(e => e.SocSecTax).HasColumnName("SOC_SEC_TAX");

                entity.Property(e => e.SubInsrnceAccId).HasColumnName("SUB_INSRNCE_ACC_ID");

                entity.Property(e => e.SubPfAccId).HasColumnName("SUB_PF_ACC_ID");

                entity.Property(e => e.TdsAccId).HasColumnName("TDS_ACC_ID");

                entity.Property(e => e.WorkId).HasColumnName("WORK_ID");
            });

            modelBuilder.Entity<PisEmpDepSource>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PIS_EMP_DEP_SOURCE_pkey");

                entity.ToTable("PIS_EMP_DEP_SOURCE");

                entity.HasIndex(e => e.BudjetSourceId);

                entity.Property(e => e.DeptId)
                    .HasColumnName("DEPT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BudjetSourceId).HasColumnName("BUDJET_SOURCE_ID");

                entity.HasOne(d => d.BudjetSource)
                    .WithMany(p => p.PisEmpDepSource)
                    .HasForeignKey(d => d.BudjetSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C004356");

                entity.HasOne(d => d.Dept)
                    .WithOne(p => p.PisEmpDepSource)
                    .HasForeignKey<PisEmpDepSource>(d => d.DeptId)
                    .HasConstraintName("SYS_C004447");
            });

            modelBuilder.Entity<PisEmpInsurancePaid>(entity =>
            {
                entity.ToTable("PIS_EMP_INSURANCE_PAID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            });

            modelBuilder.Entity<PisEmpLoans>(entity =>
            {
                entity.HasKey(e => e.LoanId)
                    .HasName("PIS_EMP_LOANS_pkey");

                entity.ToTable("PIS_EMP_LOANS");

                entity.HasIndex(e => e.EmpId);

                entity.Property(e => e.LoanId)
                    .HasColumnName("LOAN_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Cleared)
                    .HasColumnName("CLEARED")
                    .HasMaxLength(1);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.InstallmentAmt).HasColumnName("INSTALLMENT_AMT");

                entity.Property(e => e.LoanAmt).HasColumnName("LOAN_AMT");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.PaidAmount).HasColumnName("PAID_AMOUNT");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpLoans)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_LOANS_EMP_ID");
            });

            modelBuilder.Entity<PisEmpLongLeaves>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_LONG_LEAVES_pkey");

                entity.ToTable("PIS_EMP_LONG_LEAVES");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDateVs)
                    .HasColumnName("FROM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.LeaveName)
                    .HasColumnName("LEAVE_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpLongLeaves)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_LEAVES_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpLongLeaves)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_LEAVES_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmpMedExpense>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_MED_EXPENSE_pkey");

                entity.ToTable("PIS_EMP_MED_EXPENSE");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("ISSUED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.RegularAmt).HasColumnName("REGULAR_AMT");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialAmt).HasColumnName("SPECIAL_AMT");

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpMedExpense)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_MED_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpMedExpense)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_MED_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmpPunishmnts>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_PUNISHMNTS_pkey");

                entity.ToTable("PIS_EMP_PUNISHMNTS");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.PunishDate)
                    .HasColumnName("PUNISH_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.PunishType)
                    .HasColumnName("PUNISH_TYPE")
                    .HasMaxLength(90);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpPunishmnts)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_PUNISH_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpPunishmnts)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_PUNISH_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmpSrvcDtls>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_SRVC_DTLS_pkey");

                entity.ToTable("PIS_EMP_SRVC_DTLS");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmentType).HasColumnName("APPOINTMENT_TYPE");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasMaxLength(10);

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.GeoRegion).HasColumnName("GEO_REGION");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.OfficeDetail)
                    .HasColumnName("OFFICE_DETAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpSrvcDtls)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_SRVC_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpSrvcDtls)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_SRVC_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmpSuspends>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_SUSPENDS_pkey");

                entity.ToTable("PIS_EMP_SUSPENDS");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDateVs)
                    .HasColumnName("FROM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpSuspends)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_SUSPND_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpSuspends)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_SUSPND_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmpTrnsfrRec>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_EMP_TRNSFR_REC_pkey");

                entity.ToTable("PIS_EMP_TRNSFR_REC");

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmtTaken).HasColumnName("AMT_TAKEN");

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.MovedDate)
                    .HasColumnName("MOVED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.TrnsfrDate)
                    .HasColumnName("TRNSFR_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.TrnsfrdOffice)
                    .HasColumnName("TRNSFRD_OFFICE")
                    .HasMaxLength(70);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisEmpTrnsfrRec)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_TRNSFR_EMP_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmpTrnsfrRec)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_TRNSFR_LOC_POST_ID");
            });

            modelBuilder.Entity<PisEmployeeMaster>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PIS_EMPLOYEE_MASTER_pkey");

                entity.ToTable("PIS_EMPLOYEE_MASTER");

                entity.HasIndex(e => e.DeptId);

                entity.HasIndex(e => e.FirstAppointPostId);

                entity.HasIndex(e => e.LocalPostId);

                entity.HasIndex(e => e.PayementBankId);

                entity.HasIndex(e => e.PostId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("EMP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.AppoinmentType).HasColumnName("APPOINMENT_TYPE");

                entity.Property(e => e.CitCode)
                    .HasColumnName("CIT_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.CitId)
                    .HasColumnName("CIT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CitPercent).HasColumnName("CIT_PERCENT");

                entity.Property(e => e.CitizenshipNo)
                    .HasColumnName("CITIZENSHIP_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.CsIssuedDate)
                    .HasColumnName("CS_ISSUED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CsIssuedDistrict).HasColumnName("CS_ISSUED_DISTRICT");

                entity.Property(e => e.CurrentPostAppointDate)
                    .HasColumnName("CURRENT_POST_APPOINT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasMaxLength(25);

                entity.Property(e => e.DateOfBirthAd).HasColumnName("DATE_OF_BIRTH_AD");

                entity.Property(e => e.DeductAbsent)
                    .HasColumnName("DEDUCT_ABSENT")
                    .HasMaxLength(1);

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.DistrictId).HasColumnName("DISTRICT_ID");

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("FATHER_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.FirstAppointDate)
                    .HasColumnName("FIRST_APPOINT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.FirstAppointPostId).HasColumnName("FIRST_APPOINT_POST_ID");

                entity.Property(e => e.FirstNameEn)
                    .HasColumnName("FIRST_NAME_EN")
                    .HasMaxLength(70);

                entity.Property(e => e.FirstNameNp)
                    .HasColumnName("FIRST_NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1);

                entity.Property(e => e.GfName)
                    .HasColumnName("GF_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.GfOcupation).HasColumnName("GF_OCUPATION");

                entity.Property(e => e.GovtEmpId)
                    .HasColumnName("GOVT_EMP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Grades).HasColumnName("GRADES");

                entity.Property(e => e.HusbandName)
                    .HasColumnName("HUSBAND_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.InsuranceFacility)
                    .HasColumnName("INSURANCE_FACILITY")
                    .HasMaxLength(1);

                entity.Property(e => e.InsuranceNo)
                    .HasColumnName("INSURANCE_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.LastNameEn)
                    .HasColumnName("LAST_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.LastNameNp)
                    .HasColumnName("LAST_NAME_NP")
                    .HasMaxLength(50);

                entity.Property(e => e.LekhaNo)
                    .HasColumnName("LEKHA_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.MailAddress)
                    .HasColumnName("MAIL_ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.MarriedStatus)
                    .HasColumnName("MARRIED_STATUS")
                    .HasMaxLength(1);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.ParentOcupation).HasColumnName("PARENT_OCUPATION");

                entity.Property(e => e.PayementBankId).HasColumnName("PAYEMENT_BANK_ID");

                entity.Property(e => e.Paymode)
                    .HasColumnName("PAYMODE")
                    .HasMaxLength(30);

                entity.Property(e => e.PensionKosh)
                    .HasColumnName("PENSION_KOSH")
                    .HasMaxLength(2);

                entity.Property(e => e.PfId)
                    .HasColumnName("PF_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(50);

                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                entity.Property(e => e.PostLevel).HasColumnName("POST_LEVEL");

                entity.Property(e => e.PostStatus)
                    .HasColumnName("POST_STATUS")
                    .HasMaxLength(40);

                entity.Property(e => e.RelWithWillPerson)
                    .HasColumnName("REL_WITH_WILL_PERSON")
                    .HasMaxLength(25);

                entity.Property(e => e.Religion).HasColumnName("RELIGION");

                entity.Property(e => e.RetireDate)
                    .HasColumnName("RETIRE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.RoomId).HasColumnName("ROOM_ID");

                entity.Property(e => e.ServiceGroup)
                    .HasColumnName("SERVICE_GROUP")
                    .HasMaxLength(30);

                entity.Property(e => e.ServiceStatus)
                    .HasColumnName("SERVICE_STATUS")
                    .HasMaxLength(40);

                entity.Property(e => e.SpouseOcupation).HasColumnName("SPOUSE_OCUPATION");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.VdcId).HasColumnName("VDC_ID");

                entity.Property(e => e.WardNo).HasColumnName("WARD_NO");

                entity.Property(e => e.WillPerson)
                    .HasColumnName("WILL_PERSON")
                    .HasMaxLength(70);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.PisEmployeeMaster)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("SYS_C004448");

                entity.HasOne(d => d.FirstAppointPost)
                    .WithMany(p => p.PisEmployeeMasterFirstAppointPost)
                    .HasForeignKey(d => d.FirstAppointPostId)
                    .HasConstraintName("FK_FIRST_APMT_POST_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisEmployeeMaster)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_LOCAL_POST_ID");

                entity.HasOne(d => d.PayementBank)
                    .WithMany(p => p.PisEmployeeMaster)
                    .HasForeignKey(d => d.PayementBankId)
                    .HasConstraintName("FK_PAYBANK_ID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PisEmployeeMasterPost)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_POST_MST_POST_ID");
            });

            modelBuilder.Entity<PisForeignVisits>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_FOREIGN_VISITS_pkey");

                entity.ToTable("PIS_FOREIGN_VISITS");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDateAd).HasColumnName("FROM_DATE_AD");

                entity.Property(e => e.FromDateVs)
                    .HasColumnName("FROM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.FundedBy)
                    .HasColumnName("FUNDED_BY")
                    .HasMaxLength(70);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.ToDateAd).HasColumnName("TO_DATE_AD");

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.VisitingPrpse)
                    .HasColumnName("VISITING_PRPSE")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisForeignVisits)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_FORGN_LOC_POST_ID");
            });

            modelBuilder.Entity<PisFulfilledDarbandi>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_FULFILLED_DARBANDI_pkey");

                entity.ToTable("PIS_FULFILLED_DARBANDI");

                entity.HasIndex(e => e.DarbandiId);

                entity.HasIndex(e => e.LocalPostId);

                entity.HasIndex(e => e.OfficeId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmntType).HasColumnName("APPOINTMNT_TYPE");

                entity.Property(e => e.DarbandiId).HasColumnName("DARBANDI_ID");

                entity.Property(e => e.DateFulfilled)
                    .HasColumnName("DATE_FULFILLED")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.OfficeId).HasColumnName("OFFICE_ID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.HasOne(d => d.Darbandi)
                    .WithMany(p => p.PisFulfilledDarbandi)
                    .HasForeignKey(d => d.DarbandiId)
                    .HasConstraintName("FK_FULFIL_DARBANDI_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisFulfilledDarbandi)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_FULFIL_DARB_LOC_POST_ID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PisFulfilledDarbandi)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_FULFIL_DARB_OFFICE_ID");
            });

            modelBuilder.Entity<PisGeoRegion>(entity =>
            {
                entity.ToTable("PIS_GEO_REGION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Details).HasColumnName("DETAILS");

                entity.Property(e => e.GrId)
                    .HasColumnName("GR_ID")
                    .HasMaxLength(2);

                entity.Property(e => e.GrName)
                    .HasColumnName("GR_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MarksPerYear).HasColumnName("MARKS_PER_YEAR");
            });

            modelBuilder.Entity<PisHajiri>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_HAJIRI_pkey");

                entity.ToTable("PIS_HAJIRI");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Betalabis).HasColumnName("BETALABIS");

                entity.Property(e => e.Bibis).HasColumnName("BIBIS");

                entity.Property(e => e.Cabis).HasColumnName("CABIS");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Gayal).HasColumnName("GAYAL");

                entity.Property(e => e.Ghabis).HasColumnName("GHABIS");

                entity.Property(e => e.HajiriDays).HasColumnName("HAJIRI_DAYS");

                entity.Property(e => e.LocalPost).HasColumnName("LOCAL_POST");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.PublicHolidays).HasColumnName("PUBLIC_HOLIDAYS");

                entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<PisInternalTransfer>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_INTERNAL_TRANSFER_pkey");

                entity.ToTable("PIS_INTERNAL_TRANSFER");

                entity.HasIndex(e => e.AppointmntType);

                entity.HasIndex(e => e.DarbandiId);

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.OfficeId);

                entity.HasIndex(e => e.ToAppointmntType);

                entity.HasIndex(e => e.ToLocalPostId);

                entity.HasIndex(e => e.ToOfficeId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmntType).HasColumnName("APPOINTMNT_TYPE");

                entity.Property(e => e.DarbandiId).HasColumnName("DARBANDI_ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasMaxLength(10);

                entity.Property(e => e.DateOfDecision)
                    .HasColumnName("DATE_OF_DECISION")
                    .HasMaxLength(10);

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasMaxLength(10);

                entity.Property(e => e.DecisionReference)
                    .HasColumnName("DECISION_REFERENCE")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.OfficeId).HasColumnName("OFFICE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ReplacedEmpId).HasColumnName("REPLACED_EMP_ID");

                entity.Property(e => e.ToAppointmntType).HasColumnName("TO_APPOINTMNT_TYPE");

                entity.Property(e => e.ToLocalPostId).HasColumnName("TO_LOCAL_POST_ID");

                entity.Property(e => e.ToOfficeId).HasColumnName("TO_OFFICE_ID");

                entity.HasOne(d => d.AppointmntTypeNavigation)
                    .WithMany(p => p.PisInternalTransferAppointmntTypeNavigation)
                    .HasForeignKey(d => d.AppointmntType)
                    .HasConstraintName("FK_INT_APNTMT_TYPE");

                entity.HasOne(d => d.Darbandi)
                    .WithMany(p => p.PisInternalTransfer)
                    .HasForeignKey(d => d.DarbandiId)
                    .HasConstraintName("FK_INT_TRNSFR_DARBANDI_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisInternalTransfer)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_INT_TRNSFR_EMP_ID");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PisInternalTransferOffice)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_INT_TRNSFR_OFFICE_ID");

                entity.HasOne(d => d.ToAppointmntTypeNavigation)
                    .WithMany(p => p.PisInternalTransferToAppointmntTypeNavigation)
                    .HasForeignKey(d => d.ToAppointmntType)
                    .HasConstraintName("FK_INT_TO_APNTMT_TYPE");

                entity.HasOne(d => d.ToLocalPost)
                    .WithMany(p => p.PisInternalTransfer)
                    .HasForeignKey(d => d.ToLocalPostId)
                    .HasConstraintName("FK_INT_LOC_POST_ID");

                entity.HasOne(d => d.ToOffice)
                    .WithMany(p => p.PisInternalTransferToOffice)
                    .HasForeignKey(d => d.ToOfficeId)
                    .HasConstraintName("FK_INT_TRNSFR_TO_OFFICE_ID");
            });

            modelBuilder.Entity<PisLandBldngs>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_LAND_BLDNGS_pkey");

                entity.ToTable("PIS_LAND_BLDNGS");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.AquisitionTypeId).HasColumnName("AQUISITION_TYPE_ID");

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.DistrictId).HasColumnName("DISTRICT_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.OwnershipDetails)
                    .HasColumnName("OWNERSHIP_DETAILS")
                    .HasMaxLength(100);

                entity.Property(e => e.RoadId).HasColumnName("ROAD_ID");

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(70);

                entity.Property(e => e.UnitDesc)
                    .HasColumnName("UNIT_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.VdcId).HasColumnName("VDC_ID");

                entity.Property(e => e.WardNo)
                    .HasColumnName("WARD_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<PisLoanDhitoGiven>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_LOAN_DHITO_GIVEN_pkey");

                entity.ToTable("PIS_LOAN_DHITO_GIVEN");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ReasonToTake)
                    .HasColumnName("REASON_TO_TAKE")
                    .HasMaxLength(100);

                entity.Property(e => e.ReturningDuration)
                    .HasColumnName("RETURNING_DURATION")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.TransDesc)
                    .HasColumnName("TRANS_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.ValueInNrs).HasColumnName("VALUE_IN_NRS");
            });

            modelBuilder.Entity<PisLoanDhitoTaken>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_LOAN_DHITO_TAKEN_pkey");

                entity.ToTable("PIS_LOAN_DHITO_TAKEN");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ReasonToTake)
                    .HasColumnName("REASON_TO_TAKE")
                    .HasMaxLength(100);

                entity.Property(e => e.ReturningDuration)
                    .HasColumnName("RETURNING_DURATION")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.TransDesc)
                    .HasColumnName("TRANS_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.ValueInNrs).HasColumnName("VALUE_IN_NRS");
            });

            modelBuilder.Entity<PisLocalPostMaster>(entity =>
            {
                entity.HasKey(e => e.LocalPostId)
                    .HasName("PIS_LOCAL_POST_MASTER_pkey");

                entity.ToTable("PIS_LOCAL_POST_MASTER");

                entity.HasIndex(e => e.PostId);

                entity.Property(e => e.LocalPostId)
                    .HasColumnName("LOCAL_POST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alllwance).HasColumnName("ALLLWANCE");

                entity.Property(e => e.Allowance).HasColumnName("ALLOWANCE");

                entity.Property(e => e.Allwance).HasColumnName("ALLWANCE");

                entity.Property(e => e.BasicSalary).HasColumnName("BASIC_SALARY");

                entity.Property(e => e.GradeRate).HasColumnName("GRADE_RATE");

                entity.Property(e => e.InsuranceAddAmt).HasColumnName("INSURANCE_ADD_AMT");

                entity.Property(e => e.LocalPostName)
                    .HasColumnName("LOCAL_POST_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.LocalPostNameEn)
                    .HasColumnName("LOCAL_POST_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.PayrollOrder).HasColumnName("PAYROLL_ORDER");

                entity.Property(e => e.PostDuties).HasColumnName("POST_DUTIES");

                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PisLocalPostMaster)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_LO_PIS_POST_MASTER");
            });

            modelBuilder.Entity<PisNijamatiSewaSamuha>(entity =>
            {
                entity.ToTable("PIS_NIJAMATI_SEWA_SAMUHA");

                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GrpLevel).HasColumnName("GRP_LEVEL");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(100);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_NIJAMATI_PARENT_ID");
            });

            modelBuilder.Entity<PisOrnaments>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_ORNAMENTS_pkey");

                entity.ToTable("PIS_ORNAMENTS");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.AquisitionTypeId).HasColumnName("AQUISITION_TYPE_ID");

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.UnitDesc)
                    .HasColumnName("UNIT_DESC")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");
            });

            modelBuilder.Entity<PisOtherAddSub>(entity =>
            {
                entity.ToTable("PIS_OTHER_ADD_SUB");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AddSub)
                    .HasColumnName("ADD_SUB")
                    .HasMaxLength(1);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(80);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisOtherAddSub)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_ADD_SUB_LOCAL_POST_ID");
            });

            modelBuilder.Entity<PisPayrolls>(entity =>
            {
                entity.ToTable("PIS_PAYROLLS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsentDays).HasColumnName("ABSENT_DAYS");

                entity.Property(e => e.AbsentDeductAmt).HasColumnName("ABSENT_DEDUCT_AMT");

                entity.Property(e => e.AdvanceDeductAmt).HasColumnName("ADVANCE_DEDUCT_AMT");

                entity.Property(e => e.AllowanceAmt).HasColumnName("ALLOWANCE_AMT");

                entity.Property(e => e.BasicSalary).HasColumnName("BASIC_SALARY");

                entity.Property(e => e.CitAmt).HasColumnName("CIT_AMT");

                entity.Property(e => e.CitPercent).HasColumnName("CIT_PERCENT");

                entity.Property(e => e.DeductDepVchrDateNep)
                    .HasColumnName("DEDUCT_DEP_VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.DeductDepVchrId).HasColumnName("DEDUCT_DEP_VCHR_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EmpNameNp)
                    .HasColumnName("EMP_NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.FestiveVchrDateNep)
                    .HasColumnName("FESTIVE_VCHR_DATE_NEP")
                    .HasMaxLength(10);

                entity.Property(e => e.FestiveVchrId).HasColumnName("FESTIVE_VCHR_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.GradeAmount).HasColumnName("GRADE_AMOUNT");

                entity.Property(e => e.GradeIncMonth).HasColumnName("GRADE_INC_MONTH");

                entity.Property(e => e.GradeSalaryTotal).HasColumnName("GRADE_SALARY_TOTAL");

                entity.Property(e => e.InsuranceAddAmt).HasColumnName("INSURANCE_ADD_AMT");

                entity.Property(e => e.InsuranceDeductAmt).HasColumnName("INSURANCE_DEDUCT_AMT");

                entity.Property(e => e.LoanDeductAmt).HasColumnName("LOAN_DEDUCT_AMT");

                entity.Property(e => e.LocalPost)
                    .HasColumnName("LOCAL_POST")
                    .HasMaxLength(70);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NetSalary).HasColumnName("NET_SALARY");

                entity.Property(e => e.OtherAllowanceAmt).HasColumnName("OTHER_ALLOWANCE_AMT");

                entity.Property(e => e.OtherDeductTotal).HasColumnName("OTHER_DEDUCT_TOTAL");

                entity.Property(e => e.PayBankId).HasColumnName("PAY_BANK_ID");

                entity.Property(e => e.Paymode)
                    .HasColumnName("PAYMODE")
                    .HasMaxLength(30);

                entity.Property(e => e.PensionkoshAddAmt).HasColumnName("PENSIONKOSH_ADD_AMT");

                entity.Property(e => e.PensionkoshDedAmt).HasColumnName("PENSIONKOSH_DED_AMT");

                entity.Property(e => e.PfAddAmt).HasColumnName("PF_ADD_AMT");

                entity.Property(e => e.PfDeductAmt).HasColumnName("PF_DEDUCT_AMT");

                entity.Property(e => e.PostInShort)
                    .HasColumnName("POST_IN_SHORT")
                    .HasMaxLength(40);

                entity.Property(e => e.PostLevel).HasColumnName("POST_LEVEL");

                entity.Property(e => e.RateOfGrade).HasColumnName("RATE_OF_GRADE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxAmt).HasColumnName("TAX_AMT");

                entity.Property(e => e.TdsAmt).HasColumnName("TDS_AMT");

                entity.Property(e => e.TotalPayableSalary).HasColumnName("TOTAL_PAYABLE_SALARY");

                entity.Property(e => e.TransTpeId).HasColumnName("TRANS_TPE_ID");

                entity.Property(e => e.VchrDateNp)
                    .HasColumnName("VCHR_DATE_NP")
                    .HasMaxLength(10);

                entity.Property(e => e.VchrId).HasColumnName("VCHR_ID");
            });

            modelBuilder.Entity<PisPdOrgInvlvmnt>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_PD_ORG_INVLVMNT_pkey");

                entity.ToTable("PIS_PD_ORG_INVLVMNT");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.NoOfBenificPopln).HasColumnName("NO_OF_BENIFIC_POPLN");

                entity.Property(e => e.OrgAcheivmnts)
                    .HasColumnName("ORG_ACHEIVMNTS")
                    .HasMaxLength(150);

                entity.Property(e => e.OrgAdd)
                    .HasColumnName("ORG_ADD")
                    .HasMaxLength(100);

                entity.Property(e => e.OrgAims)
                    .HasColumnName("ORG_AIMS")
                    .HasMaxLength(150);

                entity.Property(e => e.OrgFormedDate)
                    .HasColumnName("ORG_FORMED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.OrgJoinedDate)
                    .HasColumnName("ORG_JOINED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.OrgLeftDate)
                    .HasColumnName("ORG_LEFT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.OrgName)
                    .HasColumnName("ORG_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.PostInOrg)
                    .HasColumnName("POST_IN_ORG")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.RespnsbltyInOrg)
                    .HasColumnName("RESPNSBLTY_IN_ORG")
                    .HasMaxLength(90);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");
            });

            modelBuilder.Entity<PisPdSrvcDtls>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_PD_SRVC_DTLS_pkey");

                entity.ToTable("PIS_PD_SRVC_DTLS");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmntLevel)
                    .HasColumnName("APPOINTMNT_LEVEL")
                    .HasMaxLength(50);

                entity.Property(e => e.AppointmntType).HasColumnName("APPOINTMNT_TYPE");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasMaxLength(10);

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.OfficeDetail)
                    .HasColumnName("OFFICE_DETAIL")
                    .HasMaxLength(70);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PisPersonVisitRecrd>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_PERSON_VISIT_RECRD_pkey");

                entity.ToTable("PIS_PERSON_VISIT_RECRD");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmountTaken).HasColumnName("AMOUNT_TAKEN");

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.JobDetails)
                    .HasColumnName("JOB_DETAILS")
                    .HasMaxLength(70);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonName)
                    .HasColumnName("PERSON_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.PersonPost)
                    .HasColumnName("PERSON_POST")
                    .HasMaxLength(70);

                entity.Property(e => e.PersonTypeId).HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.VisitLocation)
                    .HasColumnName("VISIT_LOCATION")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PisPostMaster>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PIS_POST_MASTER_pkey");

                entity.ToTable("PIS_POST_MASTER");

                entity.Property(e => e.PostId)
                    .HasColumnName("POST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasicSalary).HasColumnName("BASIC_SALARY");

                entity.Property(e => e.GeneralPost)
                    .HasColumnName("GENERAL_POST")
                    .HasMaxLength(70);

                entity.Property(e => e.GeneralPostShort)
                    .HasColumnName("GENERAL_POST_SHORT")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxGradeRate).HasColumnName("MAX_GRADE_RATE");

                entity.Property(e => e.PostLevel).HasColumnName("POST_LEVEL");

                entity.Property(e => e.PrabidikOrPrasasan).HasColumnName("PRABIDIK_OR_PRASASAN");

                entity.Property(e => e.RateOfGrade).HasColumnName("RATE_OF_GRADE");
            });

            modelBuilder.Entity<PisPrizes>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_PRIZES_pkey");

                entity.ToTable("PIS_PRIZES");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.AwardType)
                    .HasColumnName("AWARD_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.AwardedBy)
                    .HasColumnName("AWARDED_BY")
                    .HasMaxLength(70);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("ISSUED_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisPrizes)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_PRIZE_LOC_POST_ID");
            });

            modelBuilder.Entity<PisPublication>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_PUBLICATION_pkey");

                entity.ToTable("PIS_PUBLICATION");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Publisher)
                    .HasColumnName("PUBLISHER")
                    .HasMaxLength(100);

                entity.Property(e => e.PublshDateAd).HasColumnName("PUBLSH_DATE_AD");

                entity.Property(e => e.PublshDateVs)
                    .HasColumnName("PUBLSH_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisPublication)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_PBLCN_LOC_POST_ID");
            });

            modelBuilder.Entity<PisPyrollLoanDtls>(entity =>
            {
                entity.ToTable("PIS_PYROLL_LOAN_DTLS");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.EmpId);

                entity.HasIndex(e => e.LoandId);

                entity.HasIndex(e => e.PayrollId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Cleared)
                    .HasColumnName("CLEARED")
                    .HasMaxLength(1);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.InstallmentAmt).HasColumnName("INSTALLMENT_AMT");

                entity.Property(e => e.LoandAmt).HasColumnName("LOAND_AMT");

                entity.Property(e => e.LoandId).HasColumnName("LOAND_ID");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(100);

                entity.Property(e => e.PayrollId).HasColumnName("PAYROLL_ID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.PisPyrollLoanDtls)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_PYROLL_LOAN_DTLS_ACCID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PisPyrollLoanDtls)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_PYROLL_LOAN_DTLS_EMPID");

                entity.HasOne(d => d.Loand)
                    .WithMany(p => p.PisPyrollLoanDtls)
                    .HasForeignKey(d => d.LoandId)
                    .HasConstraintName("FK_PYROLL_LOAN_DTLS_LID");

                entity.HasOne(d => d.Payroll)
                    .WithMany(p => p.PisPyrollLoanDtls)
                    .HasForeignKey(d => d.PayrollId)
                    .HasConstraintName("FK_PYROLL_LOAN_DTLS_PRID");
            });

            modelBuilder.Entity<PisPyrollOthrDtls>(entity =>
            {
                entity.ToTable("PIS_PYROLL_OTHR_DTLS");

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.PayrollId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.AddSub)
                    .HasColumnName("ADD_SUB")
                    .HasMaxLength(1);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.PayrollId).HasColumnName("PAYROLL_ID");

                entity.Property(e => e.SourceType)
                    .HasColumnName("SOURCE_TYPE")
                    .HasMaxLength(2);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PisPyrollOthrDtls)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_PYROL_OTHR_DTLS_EMPID");

                entity.HasOne(d => d.Payroll)
                    .WithMany(p => p.PisPyrollOthrDtls)
                    .HasForeignKey(d => d.PayrollId)
                    .HasConstraintName("FK_PYROLL_OTHR_DTLS_ID");
            });

            modelBuilder.Entity<PisReplacedInDarbandi>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_REPLACED_IN_DARBANDI_pkey");

                entity.ToTable("PIS_REPLACED_IN_DARBANDI");

                entity.HasIndex(e => e.DarbandiId);

                entity.HasIndex(e => e.EntrySnInFd);

                entity.HasIndex(e => e.OfficeId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmntType).HasColumnName("APPOINTMNT_TYPE");

                entity.Property(e => e.DarbandiId).HasColumnName("DARBANDI_ID");

                entity.Property(e => e.DateFulfilled)
                    .HasColumnName("DATE_FULFILLED")
                    .HasMaxLength(10);

                entity.Property(e => e.DateOfDecision)
                    .HasColumnName("DATE_OF_DECISION")
                    .HasMaxLength(10);

                entity.Property(e => e.DateReplaced)
                    .HasColumnName("DATE_REPLACED")
                    .HasMaxLength(10);

                entity.Property(e => e.DecisionReference)
                    .HasColumnName("DECISION_REFERENCE")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EntrySnInFd).HasColumnName("ENTRY_SN_IN_FD");

                entity.Property(e => e.IsPlacedInDarbandi).HasColumnName("IS_PLACED_IN_DARBANDI");

                entity.Property(e => e.OfficeId).HasColumnName("OFFICE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ReplacedBy).HasColumnName("REPLACED_BY");

                entity.HasOne(d => d.Darbandi)
                    .WithMany(p => p.PisReplacedInDarbandi)
                    .HasForeignKey(d => d.DarbandiId)
                    .HasConstraintName("FK_REPL_FD_DARBANDI_ID");

                entity.HasOne(d => d.EntrySnInFdNavigation)
                    .WithMany(p => p.PisReplacedInDarbandi)
                    .HasForeignKey(d => d.EntrySnInFd)
                    .HasConstraintName("FK_ENTRY_SN_IN_FD");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PisReplacedInDarbandi)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_REPL_FD_OFFICE_ID");
            });

            modelBuilder.Entity<PisServiceStatus>(entity =>
            {
                entity.ToTable("PIS_SERVICE_STATUS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PisSgnfcntWork>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_SGNFCNT_WORK_pkey");

                entity.ToTable("PIS_SGNFCNT_WORK");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDateAd).HasColumnName("FROM_DATE_AD");

                entity.Property(e => e.FromDateVs)
                    .HasColumnName("FROM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NameNp)
                    .HasColumnName("NAME_NP")
                    .HasMaxLength(70);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.ToDateAd).HasColumnName("TO_DATE_AD");

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisSgnfcntWork)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_SGNWRK_LOC_POST_ID");
            });

            modelBuilder.Entity<PisShareBankbalance>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_SHARE_BANKBALANCE_pkey");

                entity.ToTable("PIS_SHARE_BANKBALANCE");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.AquisitionTypeId).HasColumnName("AQUISITION_TYPE_ID");

                entity.Property(e => e.CompanyOrBank)
                    .HasColumnName("COMPANY_OR_BANK")
                    .HasMaxLength(70);

                entity.Property(e => e.DataEditAdDate).HasColumnName("DATA_EDIT_AD_DATE");

                entity.Property(e => e.DataEntryAdDate).HasColumnName("DATA_ENTRY_AD_DATE");

                entity.Property(e => e.DataEntryVsDate)
                    .HasColumnName("DATA_ENTRY_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.OwnershipDetails)
                    .HasColumnName("OWNERSHIP_DETAILS")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialNotes)
                    .HasColumnName("SPECIAL_NOTES")
                    .HasMaxLength(150);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIde).HasColumnName("USER_IDE");

                entity.Property(e => e.ValueInNrs).HasColumnName("VALUE_IN_NRS");
            });

            modelBuilder.Entity<PisTraining>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_TRAINING_pkey");

                entity.ToTable("PIS_TRAINING");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.Division)
                    .HasColumnName("DIVISION")
                    .HasMaxLength(15);

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FrmDateAd).HasColumnName("FRM_DATE_AD");

                entity.Property(e => e.FrmDateVs)
                    .HasColumnName("FRM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.Institute)
                    .HasColumnName("INSTITUTE")
                    .HasMaxLength(70);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.MarksObtnd).HasColumnName("MARKS_OBTND");

                entity.Property(e => e.ToDateAd).HasColumnName("TO_DATE_AD");

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.TrainingName)
                    .HasColumnName("TRAINING_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.TrainingType)
                    .HasColumnName("TRAINING_TYPE")
                    .HasMaxLength(70);

                entity.Property(e => e.ValidForEval).HasColumnName("VALID_FOR_EVAL");

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisTraining)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_TRNG_LOC_POST_ID");
            });

            modelBuilder.Entity<PisVisitedCountries>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_VISITED_COUNTRIES_pkey");

                entity.ToTable("PIS_VISITED_COUNTRIES");

                entity.HasIndex(e => e.VisitId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.VisitId).HasColumnName("VISIT_ID");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.PisVisitedCountries)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK_VISIT_ID");
            });

            modelBuilder.Entity<PisWorkshop>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PIS_WORKSHOP_pkey");

                entity.ToTable("PIS_WORKSHOP");

                entity.HasIndex(e => e.LocalPostId);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyTo)
                    .HasColumnName("APPLY_TO")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDateAd).HasColumnName("FROM_DATE_AD");

                entity.Property(e => e.FromDateVs)
                    .HasColumnName("FROM_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.LocalPostId).HasColumnName("LOCAL_POST_ID");

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Organizer)
                    .HasColumnName("ORGANIZER")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(90);

                entity.Property(e => e.ToDateAd).HasColumnName("TO_DATE_AD");

                entity.Property(e => e.ToDateVs)
                    .HasColumnName("TO_DATE_VS")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkingOffice)
                    .HasColumnName("WORKING_OFFICE")
                    .HasMaxLength(70);

                entity.HasOne(d => d.LocalPost)
                    .WithMany(p => p.PisWorkshop)
                    .HasForeignKey(d => d.LocalPostId)
                    .HasConstraintName("FK_WRKSHP_LOC_POST_ID");
            });

            modelBuilder.Entity<PmsYojtype>(entity =>
            {
                entity.ToTable("PMS_YOJTYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.YojtypeNameEng)
                    .HasColumnName("YOJTYPE_NAME_ENG")
                    .HasMaxLength(150);

                entity.Property(e => e.YojtypeNameNp)
                    .IsRequired()
                    .HasColumnName("YOJTYPE_NAME_NP")
                    .HasMaxLength(150);

                entity.Property(e => e.YojtypeRemarks)
                    .HasColumnName("YOJTYPE_REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RentDarRate>(entity =>
            {
                entity.ToTable("RENT_DAR_RATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ratename)
                    .HasColumnName("RATENAME")
                    .HasMaxLength(100);

                entity.Property(e => e.RentPer).HasColumnName("RENT_PER");

                entity.Property(e => e.RentTypeid).HasColumnName("RENT_TYPEID");
            });

            modelBuilder.Entity<Renttype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RENTTYPE");

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReportGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_GENERAL");

                entity.Property(e => e.AnusuchiDetails)
                    .HasColumnName("ANUSUCHI_DETAILS")
                    .HasMaxLength(200);

                entity.Property(e => e.AnusuchiHead)
                    .HasColumnName("ANUSUCHI_HEAD")
                    .HasMaxLength(30);

                entity.Property(e => e.OfficeTypeId).HasColumnName("OFFICE_TYPE_ID");

                entity.Property(e => e.ReportFor)
                    .HasColumnName("REPORT_FOR")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportHeading)
                    .HasColumnName("REPORT_HEADING")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportId).HasColumnName("REPORT_ID");

                entity.Property(e => e.ReportName)
                    .HasColumnName("REPORT_NAME")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<SanitationGroup>(entity =>
            {
                entity.ToTable("SANITATION_GROUP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Groupname)
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SanitationRate>(entity =>
            {
                entity.ToTable("SANITATION_RATE");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.Subgroupid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaUpto).HasColumnName("AREA_UPTO");

                entity.Property(e => e.EachAreaRate).HasColumnName("EACH_AREA_RATE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.ForEachArea).HasColumnName("FOR_EACH_AREA");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Ratename).HasColumnName("RATENAME");

                entity.Property(e => e.RoadTypeid).HasColumnName("ROAD_TYPEID");

                entity.Property(e => e.Subgroupid).HasColumnName("SUBGROUPID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SanitationRate)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("SYS_C004386");

                entity.HasOne(d => d.Subgroup)
                    .WithMany(p => p.SanitationRate)
                    .HasForeignKey(d => d.Subgroupid)
                    .HasConstraintName("SYS_C004387");
            });

            modelBuilder.Entity<SanitationSubgroup>(entity =>
            {
                entity.ToTable("SANITATION_SUBGROUP");

                entity.HasIndex(e => e.Groupid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.Subgroupname)
                    .HasColumnName("SUBGROUPNAME")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SanitationSubgroup)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("SYS_C004385");
            });

            modelBuilder.Entity<ServiceChargeMaster>(entity =>
            {
                entity.ToTable("SERVICE_CHARGE_MASTER");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.Isapplicableforhouse).HasColumnName("ISAPPLICABLEFORHOUSE");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.ServiceChargePercent).HasColumnName("SERVICE_CHARGE_PERCENT");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.ServiceChargeMaster)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_SERVICE_CHR_ACC_ID");
            });

            modelBuilder.Entity<Spacemeasuringunits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPACEMEASURINGUNITS");

                entity.Property(e => e.Sqftperunit).HasColumnName("SQFTPERUNIT");

                entity.Property(e => e.Unitid).HasColumnName("UNITID");

                entity.Property(e => e.Unitname)
                    .HasColumnName("UNITNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Storedbills>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("STOREDBILLS_pkey");

                entity.ToTable("STOREDBILLS");

                entity.HasIndex(e => e.Billtypeid);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Billnofrom)
                    .HasColumnName("BILLNOFROM")
                    .HasMaxLength(25);

                entity.Property(e => e.Billnoto)
                    .HasColumnName("BILLNOTO")
                    .HasMaxLength(25);

                entity.Property(e => e.Billtypeid).HasColumnName("BILLTYPEID");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.Dateissued)
                    .HasColumnName("DATEISSUED")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Billtype)
                    .WithMany(p => p.Storedbills)
                    .HasForeignKey(d => d.Billtypeid)
                    .HasConstraintName("SYS_C004391");
            });

            modelBuilder.Entity<SubModuleSource>(entity =>
            {
                entity.HasKey(e => new { e.BudjetSourceId, e.SubModuleId })
                    .HasName("SUB_MODULE_SOURCE_pkey");

                entity.ToTable("SUB_MODULE_SOURCE");

                entity.HasIndex(e => e.BudjetSourceId);

                entity.Property(e => e.BudjetSourceId).HasColumnName("BUDJET_SOURCE_ID");

                entity.Property(e => e.SubModuleId).HasColumnName("SUB_MODULE_ID");

                entity.HasOne(d => d.BudjetSource)
                    .WithMany(p => p.SubModuleSource)
                    .HasForeignKey(d => d.BudjetSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C004357");

                entity.HasOne(d => d.SubModule)
                    .WithMany(p => p.SubModuleSource)
                    .HasForeignKey(d => d.SubModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C004317");
            });

            modelBuilder.Entity<SubjectArea>(entity =>
            {
                entity.ToTable("SUBJECT_AREA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(70);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NepName).HasColumnName("NEP_NAME");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SvBusinessmaster>(entity =>
            {
                entity.ToTable("SV_BUSINESSMASTER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addresschange)
                    .HasColumnName("ADDRESSCHANGE")
                    .HasMaxLength(12);

                entity.Property(e => e.Areainsquarefeets).HasColumnName("AREAINSQUAREFEETS");

                entity.Property(e => e.BusinessStatus).HasColumnName("BUSINESS_STATUS");

                entity.Property(e => e.Businessgroupid).HasColumnName("BUSINESSGROUPID");

                entity.Property(e => e.BusinessownertaxIid).HasColumnName("BUSINESSOWNERTAX_IID");

                entity.Property(e => e.Businessstartingdate)
                    .HasColumnName("BUSINESSSTARTINGDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.CloseReason)
                    .HasColumnName("CLOSE_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.ClosedVsDate)
                    .HasColumnName("CLOSED_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Contentofsignboard)
                    .HasColumnName("CONTENTOFSIGNBOARD")
                    .HasMaxLength(90);

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Emails)
                    .HasColumnName("EMAILS")
                    .HasMaxLength(100);

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Houseno)
                    .HasColumnName("HOUSENO")
                    .HasMaxLength(50);

                entity.Property(e => e.Houseowner)
                    .HasColumnName("HOUSEOWNER")
                    .HasMaxLength(70);

                entity.Property(e => e.Initialcapital).HasColumnName("INITIALCAPITAL");

                entity.Property(e => e.Initialregdate)
                    .HasColumnName("INITIALREGDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Initialregisteredoffice)
                    .HasColumnName("INITIALREGISTEREDOFFICE")
                    .HasMaxLength(70);

                entity.Property(e => e.Initialregno)
                    .HasColumnName("INITIALREGNO")
                    .HasMaxLength(30);

                entity.Property(e => e.Isinrent).HasColumnName("ISINRENT");

                entity.Property(e => e.Lengthofsignboard).HasColumnName("LENGTHOFSIGNBOARD");

                entity.Property(e => e.MailAddress)
                    .HasColumnName("MAIL_ADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Maxcapital).HasColumnName("MAXCAPITAL");

                entity.Property(e => e.Monthlyrent).HasColumnName("MONTHLYRENT");

                entity.Property(e => e.Municipallregdate)
                    .HasColumnName("MUNICIPALLREGDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Municipalregno)
                    .HasColumnName("MUNICIPALREGNO")
                    .HasMaxLength(30);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.PaidLastFiscalyear)
                    .HasColumnName("PAID_LAST_FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(50);

                entity.Property(e => e.Sanitationid).HasColumnName("SANITATIONID");

                entity.Property(e => e.Shiftdate)
                    .HasColumnName("SHIFTDATE")
                    .HasMaxLength(12);

                entity.Property(e => e.Shifttaxpayerid).HasColumnName("SHIFTTAXPAYERID");

                entity.Property(e => e.Specialnotes)
                    .HasColumnName("SPECIALNOTES")
                    .HasMaxLength(100);

                entity.Property(e => e.Sqfeetsofsignboard).HasColumnName("SQFEETSOFSIGNBOARD");

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(70);

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Trackid).HasColumnName("TRACKID");

                entity.Property(e => e.Typeid).HasColumnName("TYPEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Vdcid).HasColumnName("VDCID");

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");

                entity.Property(e => e.Widthofsignboard).HasColumnName("WIDTHOFSIGNBOARD");

                entity.Property(e => e.YearlyTranAmount).HasColumnName("YEARLY_TRAN_AMOUNT");

                entity.Property(e => e.Zoneid).HasColumnName("ZONEID");
            });

            modelBuilder.Entity<SvConstructions>(entity =>
            {
                entity.ToTable("SV_CONSTRUCTIONS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Areainsqfeet).HasColumnName("AREAINSQFEET");

                entity.Property(e => e.Constructiontypeid).HasColumnName("CONSTRUCTIONTYPEID");

                entity.Property(e => e.Constructionusestypeid).HasColumnName("CONSTRUCTIONUSESTYPEID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Heightinfeet).HasColumnName("HEIGHTINFEET");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Includeinevaluation).HasColumnName("INCLUDEINEVALUATION");

                entity.Property(e => e.Lengthinfeet).HasColumnName("LENGTHINFEET");

                entity.Property(e => e.Selfuseorinrent).HasColumnName("SELFUSEORINRENT");

                entity.Property(e => e.Specialnote)
                    .HasColumnName("SPECIALNOTE")
                    .HasMaxLength(90);

                entity.Property(e => e.Talanumber).HasColumnName("TALANUMBER");

                entity.Property(e => e.TaxpayerDefineAmount).HasColumnName("TAXPAYER_DEFINE_AMOUNT");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Vsdateofmade)
                    .HasColumnName("VSDATEOFMADE")
                    .HasMaxLength(10);

                entity.Property(e => e.Vsmappdate)
                    .HasColumnName("VSMAPPDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Widththinfeet).HasColumnName("WIDTHTHINFEET");
            });

            modelBuilder.Entity<SvHouses>(entity =>
            {
                entity.ToTable("SV_HOUSES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aquisitiondate)
                    .HasColumnName("AQUISITIONDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Areainsqfeets).HasColumnName("AREAINSQFEETS");

                entity.Property(e => e.Areaofconstructionsinsqfeets).HasColumnName("AREAOFCONSTRUCTIONSINSQFEETS");

                entity.Property(e => e.BinGis).HasColumnName("BIN_GIS");

                entity.Property(e => e.Buildingcode)
                    .HasColumnName("BUILDINGCODE")
                    .HasMaxLength(30);

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.DefineAmt).HasColumnName("DEFINE_AMT");

                entity.Property(e => e.Hasmapregistered).HasColumnName("HASMAPREGISTERED");

                entity.Property(e => e.Heightinfeets).HasColumnName("HEIGHTINFEETS");

                entity.Property(e => e.Houseconstructiontypeid).HasColumnName("HOUSECONSTRUCTIONTYPEID");

                entity.Property(e => e.Housenumber)
                    .HasColumnName("HOUSENUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Housetypeid).HasColumnName("HOUSETYPEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Includeinevaluation).HasColumnName("INCLUDEINEVALUATION");

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.Lengthinfeets).HasColumnName("LENGTHINFEETS");

                entity.Property(e => e.Mapregistereddate)
                    .HasColumnName("MAPREGISTEREDDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Numoftalas).HasColumnName("NUMOFTALAS");

                entity.Property(e => e.SalesDt)
                    .HasColumnName("SALES_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.Sanitationrateid).HasColumnName("SANITATIONRATEID");

                entity.Property(e => e.Specialnote).HasColumnName("SPECIALNOTE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Usestypeid).HasColumnName("USESTYPEID");

                entity.Property(e => e.Vsdateofmade)
                    .HasColumnName("VSDATEOFMADE")
                    .HasMaxLength(10);

                entity.Property(e => e.Widthinfeets).HasColumnName("WIDTHINFEETS");
            });

            modelBuilder.Entity<SvLands>(entity =>
            {
                entity.ToTable("SV_LANDS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aquisitiondate)
                    .HasColumnName("AQUISITIONDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Aquisitiontypeid).HasColumnName("AQUISITIONTYPEID");

                entity.Property(e => e.AreaTypeId).HasColumnName("AREA_TYPE_ID");

                entity.Property(e => e.Areainsqft).HasColumnName("AREAINSQFT");

                entity.Property(e => e.AreainsqftField).HasColumnName("AREAINSQFT_FIELD");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Deigstertypeid)
                    .HasColumnName("DEIGSTERTYPEID")
                    .HasMaxLength(2);

                entity.Property(e => e.Eastboundary)
                    .HasColumnName("EASTBOUNDARY")
                    .HasMaxLength(70);

                entity.Property(e => e.EastboundaryKitta)
                    .HasColumnName("EASTBOUNDARY_KITTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Eastrunft)
                    .HasColumnName("EASTRUNFT")
                    .HasMaxLength(5);

                entity.Property(e => e.Evalexclusionreasonid).HasColumnName("EVALEXCLUSIONREASONID");

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.GridNo)
                    .HasColumnName("GRID_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.Hastrack).HasColumnName("HASTRACK");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Includeinevaluation).HasColumnName("INCLUDEINEVALUATION");

                entity.Property(e => e.IsLrmisAdd)
                    .HasColumnName("IS_LRMIS_ADD")
                    .HasMaxLength(2);

                entity.Property(e => e.Kittanumber).HasColumnName("KITTANUMBER");

                entity.Property(e => e.LandRules).HasColumnName("LAND_RULES");

                entity.Property(e => e.Landmeasuringunitid).HasColumnName("LANDMEASURINGUNITID");

                entity.Property(e => e.Landnatureid).HasColumnName("LANDNATUREID");

                entity.Property(e => e.Landtype).HasColumnName("LANDTYPE");

                entity.Property(e => e.Locationfactorid).HasColumnName("LOCATIONFACTORID");

                entity.Property(e => e.Lqtypeid).HasColumnName("LQTYPEID");

                entity.Property(e => e.Malpotrate).HasColumnName("MALPOTRATE");

                entity.Property(e => e.Mapnumber)
                    .HasColumnName("MAPNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Mothnumber)
                    .HasColumnName("MOTHNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.NominationArea).HasColumnName("NOMINATION_AREA");

                entity.Property(e => e.NominationBreadth).HasColumnName("NOMINATION_BREADTH");

                entity.Property(e => e.NominationDirection).HasColumnName("NOMINATION_DIRECTION");

                entity.Property(e => e.NominationLength).HasColumnName("NOMINATION_LENGTH");

                entity.Property(e => e.NominationTf).HasColumnName("NOMINATION_TF");

                entity.Property(e => e.Nonfunctionalareainsqft).HasColumnName("NONFUNCTIONALAREAINSQFT");

                entity.Property(e => e.NorthboundaryKitta)
                    .HasColumnName("NORTHBOUNDARY_KITTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Northrunft)
                    .HasColumnName("NORTHRUNFT")
                    .HasMaxLength(5);

                entity.Property(e => e.Northtboundary)
                    .HasColumnName("NORTHTBOUNDARY")
                    .HasMaxLength(70);

                entity.Property(e => e.Oldvdcid).HasColumnName("OLDVDCID");

                entity.Property(e => e.Oldwardno)
                    .HasColumnName("OLDWARDNO")
                    .HasMaxLength(30);

                entity.Property(e => e.SalesDt)
                    .HasColumnName("SALES_DT")
                    .HasMaxLength(10);

                entity.Property(e => e.Selfdeclaredvalueinrs).HasColumnName("SELFDECLAREDVALUEINRS");

                entity.Property(e => e.SheetNo)
                    .HasColumnName("SHEET_NO")
                    .HasMaxLength(100);

                entity.Property(e => e.SouthboundaryKitta)
                    .HasColumnName("SOUTHBOUNDARY_KITTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Southrunft)
                    .HasColumnName("SOUTHRUNFT")
                    .HasMaxLength(5);

                entity.Property(e => e.Southtboundary)
                    .HasColumnName("SOUTHTBOUNDARY")
                    .HasMaxLength(70);

                entity.Property(e => e.Specialnote)
                    .HasColumnName("SPECIALNOTE")
                    .HasMaxLength(90);

                entity.Property(e => e.Streetname)
                    .HasColumnName("STREETNAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Tolename)
                    .HasColumnName("TOLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Trackid).HasColumnName("TRACKID");

                entity.Property(e => e.Trackrelationid).HasColumnName("TRACKRELATIONID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Usestypeid).HasColumnName("USESTYPEID");

                entity.Property(e => e.Valueinrsonaquisition).HasColumnName("VALUEINRSONAQUISITION");

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");

                entity.Property(e => e.Westboundary)
                    .HasColumnName("WESTBOUNDARY")
                    .HasMaxLength(70);

                entity.Property(e => e.WestboundaryKitta)
                    .HasColumnName("WESTBOUNDARY_KITTA")
                    .HasMaxLength(50);

                entity.Property(e => e.Westrunft)
                    .HasColumnName("WESTRUNFT")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<SvLandsmultievaluationdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SV_LANDSMULTIEVALUATIONDETAIL");

                entity.Property(e => e.Areainsqft).HasColumnName("AREAINSQFT");

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Kittanumber)
                    .HasColumnName("KITTANUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.Sn).HasColumnName("SN");
            });

            modelBuilder.Entity<SvPeople>(entity =>
            {
                entity.HasKey(e => e.Iid)
                    .HasName("SV_PEOPLE_pkey");

                entity.ToTable("SV_PEOPLE");

                entity.Property(e => e.Iid)
                    .HasColumnName("IID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CancelDate)
                    .HasColumnName("CANCEL_DATE")
                    .HasMaxLength(12);

                entity.Property(e => e.CancelReason).HasColumnName("CANCEL_REASON");

                entity.Property(e => e.Ccissueddate)
                    .HasColumnName("CCISSUEDDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Ccissueddristictid).HasColumnName("CCISSUEDDRISTICTID");

                entity.Property(e => e.Ccnumber)
                    .HasColumnName("CCNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Corespaddressline1)
                    .HasColumnName("CORESPADDRESSLINE1")
                    .HasMaxLength(50);

                entity.Property(e => e.Corespaddressline2)
                    .HasColumnName("CORESPADDRESSLINE2")
                    .HasMaxLength(50);

                entity.Property(e => e.Corespaddressline3)
                    .HasColumnName("CORESPADDRESSLINE3")
                    .HasMaxLength(50);

                entity.Property(e => e.Corespaddressline4)
                    .HasColumnName("CORESPADDRESSLINE4")
                    .HasMaxLength(50);

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(10);

                entity.Property(e => e.Eid)
                    .HasColumnName("EID")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(90);

                entity.Property(e => e.Fatherorhusband)
                    .HasColumnName("FATHERORHUSBAND")
                    .HasMaxLength(70);

                entity.Property(e => e.Firstengname)
                    .HasColumnName("FIRSTENGNAME")
                    .HasMaxLength(120);

                entity.Property(e => e.Firstnepname)
                    .HasColumnName("FIRSTNEPNAME")
                    .HasMaxLength(120);

                entity.Property(e => e.Gforfinlaw)
                    .HasColumnName("GFORFINLAW")
                    .HasMaxLength(70);

                entity.Property(e => e.Hascc).HasColumnName("HASCC");

                entity.Property(e => e.HltUnpaidAmount).HasColumnName("HLT_UNPAID_AMOUNT");

                entity.Property(e => e.HltUnpaidFiscalYear)
                    .HasColumnName("HLT_UNPAID_FISCAL_YEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Houseno)
                    .HasColumnName("HOUSENO")
                    .HasMaxLength(50);

                entity.Property(e => e.Individualtype).HasColumnName("INDIVIDUALTYPE");

                entity.Property(e => e.IptUnpaidAmount).HasColumnName("IPT_UNPAID_AMOUNT");

                entity.Property(e => e.IptUnpaidFiscalYear)
                    .HasColumnName("IPT_UNPAID_FISCAL_YEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.IsLrmisAdd)
                    .HasColumnName("IS_LRMIS_ADD")
                    .HasMaxLength(2);

                entity.Property(e => e.IsUnpaidCleared)
                    .HasColumnName("IS_UNPAID_CLEARED")
                    .HasMaxLength(1);

                entity.Property(e => e.Lastengname)
                    .HasColumnName("LASTENGNAME")
                    .HasMaxLength(64);

                entity.Property(e => e.Lastnepname)
                    .HasColumnName("LASTNEPNAME")
                    .HasMaxLength(64);

                entity.Property(e => e.Mobiles)
                    .HasColumnName("MOBILES")
                    .HasMaxLength(60);

                entity.Property(e => e.Motherlanguageid).HasColumnName("MOTHERLANGUAGEID");

                entity.Property(e => e.Nationalityid).HasColumnName("NATIONALITYID");

                entity.Property(e => e.Ocupationid).HasColumnName("OCUPATIONID");

                entity.Property(e => e.Otherdetails)
                    .HasColumnName("OTHERDETAILS")
                    .HasMaxLength(180);

                entity.Property(e => e.Phones)
                    .HasColumnName("PHONES")
                    .HasMaxLength(60);

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Sex).HasColumnName("SEX");

                entity.Property(e => e.Streetname)
                    .HasColumnName("STREETNAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Tolbikashid).HasColumnName("TOLBIKASHID");

                entity.Property(e => e.Trackid).HasColumnName("TRACKID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Vdcid).HasColumnName("VDCID");

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");

                entity.Property(e => e.Zoneid).HasColumnName("ZONEID");
            });

            modelBuilder.Entity<SvTbhousekittanumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SV_TBHOUSEKITTANUMBER");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Landid).HasColumnName("LANDID");
            });

            modelBuilder.Entity<SvVehiclemaster>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("SV_VEHICLEMASTER_pkey");

                entity.ToTable("SV_VEHICLEMASTER");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aquiredfrom)
                    .HasColumnName("AQUIREDFROM")
                    .HasMaxLength(70);

                entity.Property(e => e.Aquisitiondate)
                    .HasColumnName("AQUISITIONDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Aquisitiontype).HasColumnName("AQUISITIONTYPE");

                entity.Property(e => e.Ccorhprspower)
                    .HasColumnName("CCORHPRSPOWER")
                    .HasMaxLength(50);

                entity.Property(e => e.Chesisno)
                    .HasColumnName("CHESISNO")
                    .HasMaxLength(50);

                entity.Property(e => e.CloseReason)
                    .HasColumnName("CLOSE_REASON")
                    .HasMaxLength(200);

                entity.Property(e => e.ClosedVsDate)
                    .HasColumnName("CLOSED_VS_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasMaxLength(30);

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Engineno)
                    .HasColumnName("ENGINENO")
                    .HasMaxLength(50);

                entity.Property(e => e.Madeof)
                    .HasColumnName("MADEOF")
                    .HasMaxLength(90);

                entity.Property(e => e.Modeldescription)
                    .HasColumnName("MODELDESCRIPTION")
                    .HasMaxLength(70);

                entity.Property(e => e.Municipaltyregdate)
                    .HasColumnName("MUNICIPALTYREGDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Municipaltyregno)
                    .HasColumnName("MUNICIPALTYREGNO")
                    .HasMaxLength(30);

                entity.Property(e => e.Namasarimiti)
                    .HasColumnName("NAMASARIMITI")
                    .HasMaxLength(12);

                entity.Property(e => e.Namasaritaxpayerid).HasColumnName("NAMASARITAXPAYERID");

                entity.Property(e => e.Noofcilenders)
                    .HasColumnName("NOOFCILENDERS")
                    .HasMaxLength(50);

                entity.Property(e => e.Numberofseates)
                    .HasColumnName("NUMBEROFSEATES")
                    .HasMaxLength(50);

                entity.Property(e => e.PaidLastFiscalyear)
                    .HasColumnName("PAID_LAST_FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Registereddate)
                    .HasColumnName("REGISTEREDDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Registeredoffice)
                    .HasColumnName("REGISTEREDOFFICE")
                    .HasMaxLength(70);

                entity.Property(e => e.Specialnotes)
                    .HasColumnName("SPECIALNOTES")
                    .HasMaxLength(100);

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Usedfuel).HasColumnName("USEDFUEL");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Usestype).HasColumnName("USESTYPE");

                entity.Property(e => e.VehicleStatus).HasColumnName("VEHICLE_STATUS");

                entity.Property(e => e.Vehiclename)
                    .HasColumnName("VEHICLENAME")
                    .HasMaxLength(70);

                entity.Property(e => e.Vehicleno)
                    .HasColumnName("VEHICLENO")
                    .HasMaxLength(50);

                entity.Property(e => e.Vehicletype).HasColumnName("VEHICLETYPE");
            });

            modelBuilder.Entity<TaxAddtnlChrgDtls>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("TAX_ADDTNL_CHRG_DTLS_pkey");

                entity.ToTable("TAX_ADDTNL_CHRG_DTLS");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.Accode);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.BillNo).HasColumnName("BILL_NO");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Isapplicableforhouse).HasColumnName("ISAPPLICABLEFORHOUSE");

                entity.Property(e => e.Isregistationfee)
                    .HasColumnName("ISREGISTATIONFEE")
                    .HasMaxLength(2);

                entity.Property(e => e.LandId).HasColumnName("LAND_ID");

                entity.Property(e => e.RentId).HasColumnName("RENT_ID");

                entity.Property(e => e.ServiceChargePercent).HasColumnName("SERVICE_CHARGE_PERCENT");

                entity.Property(e => e.ServiceChargeType)
                    .HasColumnName("SERVICE_CHARGE_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(3);

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TaxAddtnlChrgDtls)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_TAX_ADD_DTL_ACC_ID");

                entity.HasOne(d => d.AccodeNavigation)
                    .WithMany(p => p.TaxAddtnlChrgDtls)
                    .HasForeignKey(d => d.Accode)
                    .HasConstraintName("FK_TAX_ADDTNL_CHRG_DTLS_ACCODE");
            });

            modelBuilder.Entity<TaxMalpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAX_MALPOT");

                entity.Property(e => e.Additionalcharges).HasColumnName("ADDITIONALCHARGES");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Kittanumber).HasColumnName("KITTANUMBER");

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.LastTaxPaidAmount).HasColumnName("LAST_TAX_PAID_AMOUNT");

                entity.Property(e => e.Netevaluatingarea).HasColumnName("NETEVALUATINGAREA");

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Nonevaluatedarea).HasColumnName("NONEVALUATEDAREA");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Specialnotes).HasColumnName("SPECIALNOTES");

                entity.Property(e => e.Taxpaidamount).HasColumnName("TAXPAIDAMOUNT");

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Totalarea).HasColumnName("TOTALAREA");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");
            });

            modelBuilder.Entity<TaxMalpotHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAX_MALPOT_HISTORY");

                entity.Property(e => e.Additionalcharges).HasColumnName("ADDITIONALCHARGES");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Generalrateid).HasColumnName("GENERALRATEID");

                entity.Property(e => e.Kittanumber).HasColumnName("KITTANUMBER");

                entity.Property(e => e.Landid).HasColumnName("LANDID");

                entity.Property(e => e.LastTaxPaidAmount).HasColumnName("LAST_TAX_PAID_AMOUNT");

                entity.Property(e => e.MalpotId).HasColumnName("MALPOT_ID");

                entity.Property(e => e.Netevaluatingarea).HasColumnName("NETEVALUATINGAREA");

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Nonevaluatedarea).HasColumnName("NONEVALUATEDAREA");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Specialnotes).HasColumnName("SPECIALNOTES");

                entity.Property(e => e.Taxpaidamount).HasColumnName("TAXPAIDAMOUNT");

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Totalarea).HasColumnName("TOTALAREA");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");
            });

            modelBuilder.Entity<TaxRateCeiling>(entity =>
            {
                entity.ToTable("TAX_RATE_CEILING");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MarriedStatus)
                    .HasColumnName("MARRIED_STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.NpFrom)
                    .HasColumnName("NP_FROM")
                    .HasMaxLength(15);

                entity.Property(e => e.NpTo)
                    .HasColumnName("NP_TO")
                    .HasMaxLength(15);

                entity.Property(e => e.TaxRate).HasColumnName("TAX_RATE");
            });

            modelBuilder.Entity<TaxRental>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAX_RENTAL");

                entity.Property(e => e.Additionalcharges).HasColumnName("ADDITIONALCHARGES");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(12);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Constructionid).HasColumnName("CONSTRUCTIONID");

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.Dataentryaddate).HasColumnName("DATAENTRYADDATE");

                entity.Property(e => e.Dateentryvsdate)
                    .HasColumnName("DATEENTRYVSDATE")
                    .HasMaxLength(12);

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastTaxPaidAmount).HasColumnName("LAST_TAX_PAID_AMOUNT");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.Rentid).HasColumnName("RENTID");

                entity.Property(e => e.Taxpaidamount).HasColumnName("TAXPAIDAMOUNT");

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<TaxRtRentdtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAX_RT_RENTDTL");

                entity.Property(e => e.AgreementDate)
                    .HasColumnName("AGREEMENT_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.AnualRentIncome).HasColumnName("ANUAL_RENT_INCOME");

                entity.Property(e => e.Businessid).HasColumnName("BUSINESSID");

                entity.Property(e => e.ConstructionId).HasColumnName("CONSTRUCTION_ID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(12);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTaxPaidBusinessPerson)
                    .HasColumnName("IS_TAX_PAID_BUSINESS_PERSON")
                    .HasMaxLength(2);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.RentInsqfeet).HasColumnName("RENT_INSQFEET");

                entity.Property(e => e.RentStatus)
                    .HasColumnName("RENT_STATUS")
                    .HasMaxLength(5);

                entity.Property(e => e.RentTypeId).HasColumnName("RENT_TYPE_ID");

                entity.Property(e => e.Rname)
                    .HasColumnName("RNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.ValidUntil)
                    .HasColumnName("VALID_UNTIL")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TaxSanitation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAX_SANITATION");

                entity.Property(e => e.Billdate)
                    .HasColumnName("BILLDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Billid).HasColumnName("BILLID");

                entity.Property(e => e.Billno)
                    .HasColumnName("BILLNO")
                    .HasMaxLength(25);

                entity.Property(e => e.Counterid).HasColumnName("COUNTERID");

                entity.Property(e => e.Dataeditaddatetime).HasColumnName("DATAEDITADDATETIME");

                entity.Property(e => e.Dataentryaddatetime).HasColumnName("DATAENTRYADDATETIME");

                entity.Property(e => e.Dataentryvsdate)
                    .HasColumnName("DATAENTRYVSDATE")
                    .HasMaxLength(10);

                entity.Property(e => e.Fineamount).HasColumnName("FINEAMOUNT");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.LastTaxPaidAmount).HasColumnName("LAST_TAX_PAID_AMOUNT");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Nettaxamount).HasColumnName("NETTAXAMOUNT");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Reductionalcharges).HasColumnName("REDUCTIONALCHARGES");

                entity.Property(e => e.Servicetype)
                    .HasColumnName("SERVICETYPE")
                    .HasMaxLength(5);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Specialnotes).HasColumnName("SPECIALNOTES");

                entity.Property(e => e.Taxpaidamount).HasColumnName("TAXPAIDAMOUNT");

                entity.Property(e => e.Taxpayerid).HasColumnName("TAXPAYERID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Useride).HasColumnName("USERIDE");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<TaxThliIssuedCntr>(entity =>
            {
                entity.ToTable("TAX_THLI_ISSUED_CNTR");

                entity.HasIndex(e => e.CntrId);

                entity.HasIndex(e => e.TheliId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CntrId).HasColumnName("CNTR_ID");

                entity.Property(e => e.TheliId).HasColumnName("THELI_ID");

                entity.HasOne(d => d.Cntr)
                    .WithMany(p => p.TaxThliIssuedCntr)
                    .HasForeignKey(d => d.CntrId)
                    .HasConstraintName("SYS_C004358");

                entity.HasOne(d => d.Theli)
                    .WithMany(p => p.TaxThliIssuedCntr)
                    .HasForeignKey(d => d.TheliId)
                    .HasConstraintName("SYS_C004388");
            });

            modelBuilder.Entity<Tbhousekittanumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBHOUSEKITTANUMBER");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Landid).HasColumnName("LANDID");
            });

            modelBuilder.Entity<TblBankAccntType>(entity =>
            {
                entity.ToTable("TBL_BANK_ACCNT_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblBankFinanceInstitutue>(entity =>
            {
                entity.ToTable("TBL_BANK_FINANCE_INSTITUTUE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasColumnName("ACCOUNT_NAME");

                entity.Property(e => e.Descriptiong).HasColumnName("DESCRIPTIONG");

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.NpName).HasColumnName("NP_NAME");
            });

            modelBuilder.Entity<TblBgtMgmt>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgtSubHeadId).HasColumnName("BGT_SUB_HEAD_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.TotalBgtAmt).HasColumnName("TOTAL_BGT_AMT");
            });

            modelBuilder.Entity<TblBgtMgmtExp>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_EXP");

                entity.HasIndex(e => e.BgtMgmtId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.BgtAmt).HasColumnName("BGT_AMT");

                entity.Property(e => e.BgtMgmtId).HasColumnName("BGT_MGMT_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.HasOne(d => d.BgtMgmt)
                    .WithMany(p => p.TblBgtMgmtExp)
                    .HasForeignKey(d => d.BgtMgmtId)
                    .HasConstraintName("FK_BGT_MGMT");
            });

            modelBuilder.Entity<TblBgtMgmtExpOrg>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_EXP_ORG");

                entity.HasIndex(e => e.BgtMgmtOrgId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.BgtAmtOrg).HasColumnName("BGT_AMT_ORG");

                entity.Property(e => e.BgtMgmtOrgId).HasColumnName("BGT_MGMT_ORG_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.HasOne(d => d.BgtMgmtOrg)
                    .WithMany(p => p.TblBgtMgmtExpOrg)
                    .HasForeignKey(d => d.BgtMgmtOrgId)
                    .HasConstraintName("FK_BGT_MGMT_ORG");
            });

            modelBuilder.Entity<TblBgtMgmtExpRelease>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_EXP_RELEASE");

                entity.HasIndex(e => e.BgtMgmtReleaseId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.BgtMgmtReleaseId).HasColumnName("BGT_MGMT_RELEASE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.HasOne(d => d.BgtMgmtRelease)
                    .WithMany(p => p.TblBgtMgmtExpRelease)
                    .HasForeignKey(d => d.BgtMgmtReleaseId)
                    .HasConstraintName("FK_BGT_MGMT_RELEASE");
            });

            modelBuilder.Entity<TblBgtMgmtOrg>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_ORG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgtSubHeadId).HasColumnName("BGT_SUB_HEAD_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.TotalBgtAmtOrg).HasColumnName("TOTAL_BGT_AMT_ORG");
            });

            modelBuilder.Entity<TblBgtMgmtRelease>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_RELEASE");

                entity.HasIndex(e => e.BgtReleaseId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.BgtReleaseId).HasColumnName("BGT_RELEASE_ID");

                entity.Property(e => e.BgtSubHeadId).HasColumnName("BGT_SUB_HEAD_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.HasOne(d => d.BgtRelease)
                    .WithMany(p => p.TblBgtMgmtRelease)
                    .HasForeignKey(d => d.BgtReleaseId)
                    .HasConstraintName("FK_BGT_MGMT_REL");
            });

            modelBuilder.Entity<TblBgtMgmtSrc>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_SRC");

                entity.HasIndex(e => e.BgtMgmtExpId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.BgtMgmtExpId).HasColumnName("BGT_MGMT_EXP_ID");

                entity.Property(e => e.PaymentProcessId).HasColumnName("PAYMENT_PROCESS_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PAYMENT_TYPE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceId).HasColumnName("SOURCE_ID");

                entity.HasOne(d => d.BgtMgmtExp)
                    .WithMany(p => p.TblBgtMgmtSrc)
                    .HasForeignKey(d => d.BgtMgmtExpId)
                    .HasConstraintName("FK_BGT_MGMT_EXP");
            });

            modelBuilder.Entity<TblBgtMgmtSrcOrg>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_SRC_ORG");

                entity.HasIndex(e => e.BgtMgmtExpOrgId);

                entity.HasIndex(e => e.CcId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.BgtMgmtExpOrgId).HasColumnName("BGT_MGMT_EXP_ORG_ID");

                entity.Property(e => e.CcActive)
                    .HasColumnName("CC_ACTIVE")
                    .HasMaxLength(2);

                entity.Property(e => e.CcId).HasColumnName("CC_ID");

                entity.Property(e => e.PaymentProcessId).HasColumnName("PAYMENT_PROCESS_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PAYMENT_TYPE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceId).HasColumnName("SOURCE_ID");

                entity.HasOne(d => d.BgtMgmtExpOrg)
                    .WithMany(p => p.TblBgtMgmtSrcOrg)
                    .HasForeignKey(d => d.BgtMgmtExpOrgId)
                    .HasConstraintName("FK_BGT_MGMT_ORG_EXP");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.TblBgtMgmtSrcOrg)
                    .HasForeignKey(d => d.CcId)
                    .HasConstraintName("FK_CC");
            });

            modelBuilder.Entity<TblBgtMgmtSrcRelease>(entity =>
            {
                entity.ToTable("TBL_BGT_MGMT_SRC_RELEASE");

                entity.HasIndex(e => e.BgtMgmtExpReleaseId);

                entity.HasIndex(e => e.CcId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.BgtMgmtExpReleaseId).HasColumnName("BGT_MGMT_EXP_RELEASE_ID");

                entity.Property(e => e.CcActive)
                    .HasColumnName("CC_ACTIVE")
                    .HasMaxLength(2);

                entity.Property(e => e.CcId).HasColumnName("CC_ID");

                entity.Property(e => e.PaymentProcessId).HasColumnName("PAYMENT_PROCESS_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PAYMENT_TYPE_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceId).HasColumnName("SOURCE_ID");

                entity.HasOne(d => d.BgtMgmtExpRelease)
                    .WithMany(p => p.TblBgtMgmtSrcRelease)
                    .HasForeignKey(d => d.BgtMgmtExpReleaseId)
                    .HasConstraintName("FK_BGT_MGMT_REL_EXP");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.TblBgtMgmtSrcRelease)
                    .HasForeignKey(d => d.CcId)
                    .HasConstraintName("FK_CC_RELEASE");
            });

            modelBuilder.Entity<TblBgtRelease>(entity =>
            {
                entity.ToTable("TBL_BGT_RELEASE");

                entity.HasIndex(e => e.OrgId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprovedBgtYearly).HasColumnName("APPROVED_BGT_YEARLY");

                entity.Property(e => e.ChalaniNo)
                    .HasColumnName("CHALANI_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.LetterSn)
                    .HasColumnName("LETTER_SN")
                    .HasMaxLength(50);

                entity.Property(e => e.MinistryId).HasColumnName("MINISTRY_ID");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.PreviousReleaseAmt).HasColumnName("PREVIOUS_RELEASE_AMT");

                entity.Property(e => e.ReleaseAmount).HasColumnName("RELEASE_AMOUNT");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("RELEASE_DATE")
                    .HasMaxLength(10);

                entity.Property(e => e.ReleaseType).HasColumnName("RELEASE_TYPE");

                entity.Property(e => e.SpecialTippani).HasColumnName("SPECIAL_TIPPANI");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.TblBgtRelease)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_BGT_REL_ORG");
            });

            modelBuilder.Entity<TblConstructionOtherCharges>(entity =>
            {
                entity.ToTable("TBL_CONSTRUCTION_OTHER_CHARGES");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.PercentOfTax).HasColumnName("PERCENT_OF_TAX");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.ServiceChargeCalculation).HasColumnName("SERVICE_CHARGE_CALCULATION");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TblConstructionOtherCharges)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_CONST_OTH_CH_ACC_ID");
            });

            modelBuilder.Entity<TblDataHistory>(entity =>
            {
                entity.ToTable("TBL_DATA_HISTORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnName("ADD_DATE");

                entity.Property(e => e.ComputerName)
                    .HasColumnName("COMPUTER_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DataStatus)
                    .HasColumnName("DATA_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NewValue).HasColumnName("NEW_VALUE");

                entity.Property(e => e.OldValue)
                    .HasColumnName("OLD_VALUE")
                    .HasMaxLength(100);

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.TranTime)
                    .HasColumnName("TRAN_TIME")
                    .HasMaxLength(20);

                entity.Property(e => e.UserIdA).HasColumnName("USER_ID_A");

                entity.Property(e => e.WindowsUser)
                    .HasColumnName("WINDOWS_USER")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDegister>(entity =>
            {
                entity.ToTable("TBL_DEGISTER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.IsFullDegister).HasColumnName("IS_FULL_DEGISTER");

                entity.Property(e => e.NpName)
                    .HasColumnName("NP_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            });

            modelBuilder.Entity<TblKharidaAadash>(entity =>
            {
                entity.ToTable("TBL_KHARIDA_AADASH");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NpName)
                    .HasColumnName("NP_NAME")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblLandOtherCharges>(entity =>
            {
                entity.ToTable("TBL_LAND_OTHER_CHARGES");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.PercentOfTax).HasColumnName("PERCENT_OF_TAX");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.ServiceChargeCalculation).HasColumnName("SERVICE_CHARGE_CALCULATION");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TblLandOtherCharges)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_LAN_OTH_CHA_ACC_ID");
            });

            modelBuilder.Entity<TblMalpotOtherCharges>(entity =>
            {
                entity.ToTable("TBL_MALPOT_OTHER_CHARGES");

                entity.HasIndex(e => e.AccId);

                entity.HasIndex(e => e.Rateid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.PercentOfTax).HasColumnName("PERCENT_OF_TAX");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TblMalpotOtherCharges)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_MAL_OTH_CH_ACC_ID");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.TblMalpotOtherCharges)
                    .HasForeignKey(d => d.Rateid)
                    .HasConstraintName("SYS_C004396");
            });

            modelBuilder.Entity<TblNaliType>(entity =>
            {
                entity.ToTable("TBL_NALI_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.Engname)
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblOrganizationmaster>(entity =>
            {
                entity.ToTable("TBL_ORGANIZATIONMASTER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descriptiong).HasColumnName("DESCRIPTIONG");

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.NpName).HasColumnName("NP_NAME");
            });

            modelBuilder.Entity<TblPaymentOrder>(entity =>
            {
                entity.ToTable("TBL_PAYMENT_ORDER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateBs)
                    .HasColumnName("DATE_BS")
                    .HasMaxLength(15);

                entity.Property(e => e.OrderCode)
                    .HasColumnName("ORDER_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.TokenNo)
                    .HasColumnName("TOKEN_NO")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPaymentOrderDetails>(entity =>
            {
                entity.ToTable("TBL_PAYMENT_ORDER_DETAILS");

                entity.HasIndex(e => e.PaymentOrderId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LinkVoucherId).HasColumnName("LINK_VOUCHER_ID");

                entity.Property(e => e.PaymentOrderId).HasColumnName("PAYMENT_ORDER_ID");

                entity.Property(e => e.PaymentPermissNo)
                    .HasColumnName("PAYMENT_PERMISS_NO")
                    .HasMaxLength(200);

                entity.Property(e => e.VoucherId).HasColumnName("VOUCHER_ID");

                entity.HasOne(d => d.PaymentOrder)
                    .WithMany(p => p.TblPaymentOrderDetails)
                    .HasForeignKey(d => d.PaymentOrderId)
                    .HasConstraintName("FK_DETAILS_TBL_PAYMENT_ORDER");
            });

            modelBuilder.Entity<TblPaymentProcess>(entity =>
            {
                entity.ToTable("TBL_PAYMENT_PROCESS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PaymentProcess)
                    .HasColumnName("PAYMENT_PROCESS")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentProcessEng)
                    .HasColumnName("PAYMENT_PROCESS_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblPaymentType>(entity =>
            {
                entity.ToTable("TBL_PAYMENT_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentTypeEng)
                    .HasColumnName("PAYMENT_TYPE_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblPropertyTax>(entity =>
            {
                entity.ToTable("TBL_PROPERTY_TAX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(12);

                entity.Property(e => e.HouseLandAmount).HasColumnName("HOUSE_LAND_AMOUNT");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.MalpotAmount).HasColumnName("MALPOT_AMOUNT");

                entity.Property(e => e.NpEntryDate)
                    .HasColumnName("NP_ENTRY_DATE")
                    .HasMaxLength(12);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.TotalTax).HasColumnName("TOTAL_TAX");
            });

            modelBuilder.Entity<TblSanitaionTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_SANITAION_TAX");

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(15);

                entity.Property(e => e.FromArea).HasColumnName("FROM_AREA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsApartment)
                    .HasColumnName("IS_APARTMENT")
                    .HasMaxLength(2);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.ToArea).HasColumnName("TO_AREA");
            });

            modelBuilder.Entity<TblStatusDetails>(entity =>
            {
                entity.ToTable("TBL_STATUS_DETAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Masterid).HasColumnName("MASTERID");

                entity.Property(e => e.NotRepairQty).HasColumnName("NOT_REPAIR_QTY");

                entity.Property(e => e.NotUseInQty).HasColumnName("NOT_USE_IN_QTY");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.RepairQty).HasColumnName("REPAIR_QTY");

                entity.Property(e => e.SpecId).HasColumnName("SPEC_ID");

                entity.Property(e => e.StockQty).HasColumnName("STOCK_QTY");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.UseInQty).HasColumnName("USE_IN_QTY");
            });

            modelBuilder.Entity<TblTaxType>(entity =>
            {
                entity.ToTable("TBL_TAX_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(200);

                entity.Property(e => e.Descriptiong).HasColumnName("DESCRIPTIONG");

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.NpName).HasColumnName("NP_NAME");
            });

            modelBuilder.Entity<TblTaxsourcerecordnew>(entity =>
            {
                entity.HasKey(e => e.Taxsrcid)
                    .HasName("TBL_TAXSOURCERECORDNEW_pkey");

                entity.ToTable("TBL_TAXSOURCERECORDNEW");

                entity.Property(e => e.Taxsrcid)
                    .HasColumnName("TAXSRCID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amountnotcollected).HasColumnName("AMOUNTNOTCOLLECTED");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.NetincomeCurfy).HasColumnName("NETINCOME_CURFY");

                entity.Property(e => e.NetincomeLastfy).HasColumnName("NETINCOME_LASTFY");

                entity.Property(e => e.Recordtype).HasColumnName("RECORDTYPE");

                entity.Property(e => e.Taxnotpaidtaxpayercnt).HasColumnName("TAXNOTPAIDTAXPAYERCNT");

                entity.Property(e => e.TaxpaidtaxpayercntCurfy).HasColumnName("TAXPAIDTAXPAYERCNT_CURFY");

                entity.Property(e => e.TaxpaidtaxpayercntLastfy).HasColumnName("TAXPAIDTAXPAYERCNT_LASTFY");

                entity.Property(e => e.Totaltaxpayercnt).HasColumnName("TOTALTAXPAYERCNT");
            });

            modelBuilder.Entity<TblTolabikasaOrg>(entity =>
            {
                entity.ToTable("TBL_TOLABIKASA_ORG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.Chairman)
                    .HasColumnName("CHAIRMAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Contactno)
                    .HasColumnName("CONTACTNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.NpName)
                    .HasColumnName("NP_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.Sachiba)
                    .HasColumnName("SACHIBA")
                    .HasMaxLength(50);

                entity.Property(e => e.Wardno).HasColumnName("WARDNO");
            });

            modelBuilder.Entity<TblVehicleParts>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("TBL_VEHICLE_PARTS_pkey");

                entity.ToTable("TBL_VEHICLE_PARTS");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NpName)
                    .HasColumnName("NP_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            });

            modelBuilder.Entity<Tblbilltype>(entity =>
            {
                entity.ToTable("TBLBILLTYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.Isincome)
                    .HasColumnName("ISINCOME")
                    .HasMaxLength(1);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblbusinessServiceChMst>(entity =>
            {
                entity.ToTable("TBLBUSINESS_SERVICE_CH_MST");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.Flatchargerate).HasColumnName("FLATCHARGERATE");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Servicechargepercent).HasColumnName("SERVICECHARGEPERCENT");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TblbusinessServiceChMst)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_BUS_SERCH_ACC_ID");
            });

            modelBuilder.Entity<Tblexeversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLEXEVERSION");

                entity.Property(e => e.Exedate).HasColumnName("EXEDATE");

                entity.Property(e => e.Exeid).HasColumnName("EXEID");
            });

            modelBuilder.Entity<Tblfywisebtrates>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLFYWISEBTRATES");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20);

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Snsubgroup).HasColumnName("SNSUBGROUP");

                entity.Property(e => e.Subgroupid).HasColumnName("SUBGROUPID");
            });

            modelBuilder.Entity<Tblfywisempotassrate>(entity =>
            {
                entity.ToTable("TBLFYWISEMPOTASSRATE");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.Rateid);

                entity.HasIndex(e => e.Subgroupid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaUpto).HasColumnName("AREA_UPTO");

                entity.Property(e => e.EachAreaRate).HasColumnName("EACH_AREA_RATE");

                entity.Property(e => e.Fiscalyear)
                    .HasColumnName("FISCALYEAR")
                    .HasMaxLength(9);

                entity.Property(e => e.ForEachArea).HasColumnName("FOR_EACH_AREA");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Subgroupid).HasColumnName("SUBGROUPID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Tblfywisempotassrate)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("SYS_C004394");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.Tblfywisempotassrate)
                    .HasForeignKey(d => d.Rateid)
                    .HasConstraintName("SYS_C004395");

                entity.HasOne(d => d.Subgroup)
                    .WithMany(p => p.Tblfywisempotassrate)
                    .HasForeignKey(d => d.Subgroupid)
                    .HasConstraintName("SYS_C004398");
            });

            modelBuilder.Entity<TblhlAddSubtract>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("TBLHL_ADD_SUBTRACT_pkey");

                entity.ToTable("TBLHL_ADD_SUBTRACT");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddFlag)
                    .HasColumnName("ADD_FLAG")
                    .HasMaxLength(1);

                entity.Property(e => e.AddSubTractType)
                    .HasColumnName("ADD_SUB_TRACT_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatRate).HasColumnName("FLAT_RATE");

                entity.Property(e => e.RatePercent).HasColumnName("RATE_PERCENT");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");
            });

            modelBuilder.Entity<TbllandTypeArea>(entity =>
            {
                entity.ToTable("TBLLAND_TYPE_AREA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tblmalpotgroup>(entity =>
            {
                entity.ToTable("TBLMALPOTGROUP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tblmalpotrates>(entity =>
            {
                entity.ToTable("TBLMALPOTRATES");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.Subgroupid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaUpto).HasColumnName("AREA_UPTO");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.EachAreaRate).HasColumnName("EACH_AREA_RATE");

                entity.Property(e => e.ForEachArea).HasColumnName("FOR_EACH_AREA");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Rateperunit).HasColumnName("RATEPERUNIT");

                entity.Property(e => e.Subgroupid).HasColumnName("SUBGROUPID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Tblmalpotrates)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("SYS_C004393");

                entity.HasOne(d => d.Subgroup)
                    .WithMany(p => p.Tblmalpotrates)
                    .HasForeignKey(d => d.Subgroupid)
                    .HasConstraintName("SYS_C004397");
            });

            modelBuilder.Entity<Tblmalpotsubgroup>(entity =>
            {
                entity.ToTable("TBLMALPOTSUBGROUP");

                entity.HasIndex(e => e.Groupid);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Worda).HasColumnName("WORDA");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Tblmalpotsubgroup)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("SYS_C004392");
            });

            modelBuilder.Entity<TbltaxFineRebate>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("TBLTAX_FINE_REBATE_pkey");

                entity.ToTable("TBLTAX_FINE_REBATE");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedNever();

                entity.Property(e => e.DurationInYears).HasColumnName("DURATION_IN_YEARS");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatRate).HasColumnName("FLAT_RATE");

                entity.Property(e => e.RatePercent).HasColumnName("RATE_PERCENT");

                entity.Property(e => e.RebateFlag)
                    .HasColumnName("REBATE_FLAG")
                    .HasMaxLength(1);

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Tbltaxcalculationroka>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLTAXCALCULATIONROKA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(255);

                entity.Property(e => e.RokaDate)
                    .HasColumnName("ROKA_DATE")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TblvehSerChMstr>(entity =>
            {
                entity.ToTable("TBLVEH_SER_CH_MSTR");

                entity.HasIndex(e => e.AccId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccId).HasColumnName("ACC_ID");

                entity.Property(e => e.Accode).HasColumnName("ACCODE");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(10);

                entity.Property(e => e.FlatChargeRate).HasColumnName("FLAT_CHARGE_RATE");

                entity.Property(e => e.Rateid).HasColumnName("RATEID");

                entity.Property(e => e.ServiceChargePercent).HasColumnName("SERVICE_CHARGE_PERCENT");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TblvehSerChMstr)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_LAND_SERCH_ACC_ID");
            });

            modelBuilder.Entity<Tbusersecurityrights>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBUSERSECURITYRIGHTS");

                entity.Property(e => e.Rightsid).HasColumnName("RIGHTSID");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TYPES");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Userassignments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERASSIGNMENTS");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Createdat)
                    .HasColumnName("CREATEDAT")
                    .HasDefaultValueSql("'2001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100);

                entity.Property(e => e.Displayname)
                    .HasColumnName("DISPLAYNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasMaxLength(50);

                entity.Property(e => e.Islocked).HasColumnName("ISLOCKED");

                entity.Property(e => e.Menuname)
                    .HasColumnName("MENUNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Menuorder)
                    .HasColumnName("MENUORDER")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Menuurl)
                    .HasColumnName("MENUURL")
                    .HasMaxLength(500);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(5);

                entity.Property(e => e.Nepname)
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(90);

                entity.Property(e => e.Parentmenuid).HasColumnName("PARENTMENUID");

                entity.Property(e => e.Rightsname)
                    .HasColumnName("RIGHTSNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            });
              
            modelBuilder.Entity<Vdc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VDC");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.Typeid).HasColumnName("TYPEID");

                entity.Property(e => e.Vdcid).HasColumnName("VDCID");
            });

            modelBuilder.Entity<WardMaster>(entity =>
            {
                entity.ToTable("WARD_MASTER");

                entity.HasIndex(e => e.PramukhId);

                entity.HasIndex(e => e.UppramukhId);

                entity.HasIndex(e => e.WardSecretaryId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.NepName)
                    .HasColumnName("NEP_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.NumberOfMembers).HasColumnName("NUMBER_OF_MEMBERS");

                entity.Property(e => e.PramukhId).HasColumnName("PRAMUKH_ID");

                entity.Property(e => e.UppramukhId).HasColumnName("UPPRAMUKH_ID");

                entity.Property(e => e.WardSecretaryId).HasColumnName("WARD_SECRETARY_ID");

                entity.HasOne(d => d.Pramukh)
                    .WithMany(p => p.WardMasterPramukh)
                    .HasForeignKey(d => d.PramukhId)
                    .HasConstraintName("FK_WARD_PRAMUKH_ID");

                entity.HasOne(d => d.Uppramukh)
                    .WithMany(p => p.WardMasterUppramukh)
                    .HasForeignKey(d => d.UppramukhId)
                    .HasConstraintName("FK_WARD_UPAPRAMUKH_ID");

                entity.HasOne(d => d.WardSecretary)
                    .WithMany(p => p.WardMaster)
                    .HasForeignKey(d => d.WardSecretaryId)
                    .HasConstraintName("FK_WARD_SECRETARY_ID");
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZONE");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Engname)
                    .IsRequired()
                    .HasColumnName("ENGNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nepname)
                    .IsRequired()
                    .HasColumnName("NEPNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100);

                entity.Property(e => e.Zoneid).HasColumnName("ZONEID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

