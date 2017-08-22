namespace testPerhitunganPajak
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__Employee> C__Employee { get; set; }
        public virtual DbSet<C__EmployeeEmergeLeave> C__EmployeeEmergeLeave { get; set; }
        public virtual DbSet<C__EmployeeSalaryComponent> C__EmployeeSalaryComponent { get; set; }
        public virtual DbSet<C__Roster> C__Roster { get; set; }
        public virtual DbSet<C__SalaryComponent> C__SalaryComponent { get; set; }
        public virtual DbSet<C__SalaryEmployeePayment> C__SalaryEmployeePayment { get; set; }
        public virtual DbSet<C__UserPassword> C__UserPassword { get; set; }
        public virtual DbSet<C_AccountJournal> C_AccountJournal { get; set; }
        public virtual DbSet<C_AccountJournalCostCenter> C_AccountJournalCostCenter { get; set; }
        public virtual DbSet<C_AccountJournalDetail> C_AccountJournalDetail { get; set; }
        public virtual DbSet<C_AccountJournalOrganization> C_AccountJournalOrganization { get; set; }
        public virtual DbSet<C_AttachmentImage> C_AttachmentImage { get; set; }
        public virtual DbSet<C_AttendanceCode> C_AttendanceCode { get; set; }
        public virtual DbSet<C_AttendanceType> C_AttendanceType { get; set; }
        public virtual DbSet<C_BaseRate> C_BaseRate { get; set; }
        public virtual DbSet<C_BaseRateAttendanceCode> C_BaseRateAttendanceCode { get; set; }
        public virtual DbSet<C_BaseRateDetail> C_BaseRateDetail { get; set; }
        public virtual DbSet<C_BaseRateGroupType> C_BaseRateGroupType { get; set; }
        public virtual DbSet<C_BaseRateTag> C_BaseRateTag { get; set; }
        public virtual DbSet<C_BaseRateTag2> C_BaseRateTag2 { get; set; }
        public virtual DbSet<C_BlackListIdNumber> C_BlackListIdNumber { get; set; }
        public virtual DbSet<C_Branch> C_Branch { get; set; }
        public virtual DbSet<C_BranchAsset> C_BranchAsset { get; set; }
        public virtual DbSet<C_Break> C_Break { get; set; }
        public virtual DbSet<C_BreakDetail> C_BreakDetail { get; set; }
        public virtual DbSet<C_Calendar> C_Calendar { get; set; }
        public virtual DbSet<C_CalendarDetail> C_CalendarDetail { get; set; }
        public virtual DbSet<C_CashTransferField> C_CashTransferField { get; set; }
        public virtual DbSet<C_CashTransferFieldDetail> C_CashTransferFieldDetail { get; set; }
        public virtual DbSet<C_Claim> C_Claim { get; set; }
        public virtual DbSet<C_ClaimDetail> C_ClaimDetail { get; set; }
        public virtual DbSet<C_Class> C_Class { get; set; }
        public virtual DbSet<C_Competency> C_Competency { get; set; }
        public virtual DbSet<C_CompetencyAppraisal> C_CompetencyAppraisal { get; set; }
        public virtual DbSet<C_CompetencyBranch> C_CompetencyBranch { get; set; }
        public virtual DbSet<C_CompetencyCore> C_CompetencyCore { get; set; }
        public virtual DbSet<C_CompetencyCoreAppraisal> C_CompetencyCoreAppraisal { get; set; }
        public virtual DbSet<C_CompetencyCoreGrade> C_CompetencyCoreGrade { get; set; }
        public virtual DbSet<C_CompetencyCoreKeyAction> C_CompetencyCoreKeyAction { get; set; }
        public virtual DbSet<C_CompetencyCoreScale> C_CompetencyCoreScale { get; set; }
        public virtual DbSet<C_CompetencyFinalResult> C_CompetencyFinalResult { get; set; }
        public virtual DbSet<C_CompetencyGrade> C_CompetencyGrade { get; set; }
        public virtual DbSet<C_CompetencyJob> C_CompetencyJob { get; set; }
        public virtual DbSet<C_CompetencyJobResult> C_CompetencyJobResult { get; set; }
        public virtual DbSet<C_CompetencyKPI> C_CompetencyKPI { get; set; }
        public virtual DbSet<C_CompetencyKPIResult> C_CompetencyKPIResult { get; set; }
        public virtual DbSet<C_CostNotaDinas> C_CostNotaDinas { get; set; }
        public virtual DbSet<C_CostNotaDinasActivity> C_CostNotaDinasActivity { get; set; }
        public virtual DbSet<C_CostNotaDinasActivityDetail> C_CostNotaDinasActivityDetail { get; set; }
        public virtual DbSet<C_CostNotaDinasDetail> C_CostNotaDinasDetail { get; set; }
        public virtual DbSet<C_CostNotaDinasDetailJobTitle> C_CostNotaDinasDetailJobTitle { get; set; }
        public virtual DbSet<C_CostNotaDinasDetailTypeSchedule> C_CostNotaDinasDetailTypeSchedule { get; set; }
        public virtual DbSet<C_CostNotaDinasDetailTypeTransport> C_CostNotaDinasDetailTypeTransport { get; set; }
        public virtual DbSet<C_CostNotaDinasMatrix> C_CostNotaDinasMatrix { get; set; }
        public virtual DbSet<C_CostNotaDinasMatrixDetail> C_CostNotaDinasMatrixDetail { get; set; }
        public virtual DbSet<C_CurrencyRate> C_CurrencyRate { get; set; }
        public virtual DbSet<C_CustomField> C_CustomField { get; set; }
        public virtual DbSet<C_CustomFieldData> C_CustomFieldData { get; set; }
        public virtual DbSet<C_CustomFieldDefinition> C_CustomFieldDefinition { get; set; }
        public virtual DbSet<C_CustomFieldHistory> C_CustomFieldHistory { get; set; }
        public virtual DbSet<C_DropDownItem> C_DropDownItem { get; set; }
        public virtual DbSet<C_DropDownItemDetail> C_DropDownItemDetail { get; set; }
        public virtual DbSet<C_Employee> C_Employee { get; set; }
        public virtual DbSet<C_EmployeeBank> C_EmployeeBank { get; set; }
        public virtual DbSet<C_EmployeeBranchAsset> C_EmployeeBranchAsset { get; set; }
        public virtual DbSet<C_EmployeeCC> C_EmployeeCC { get; set; }
        public virtual DbSet<C_EmployeeCostCenter> C_EmployeeCostCenter { get; set; }
        public virtual DbSet<C_EmployeeDependent> C_EmployeeDependent { get; set; }
        public virtual DbSet<C_EmployeeDocument> C_EmployeeDocument { get; set; }
        public virtual DbSet<C_EmployeeEducation> C_EmployeeEducation { get; set; }
        public virtual DbSet<C_EmployeeEmergeClaim> C_EmployeeEmergeClaim { get; set; }
        public virtual DbSet<C_EmployeeEmergeLeave> C_EmployeeEmergeLeave { get; set; }
        public virtual DbSet<C_EmployeeEmergeRO> C_EmployeeEmergeRO { get; set; }
        public virtual DbSet<C_EmployeeExperience> C_EmployeeExperience { get; set; }
        public virtual DbSet<C_EmployeeExpertise> C_EmployeeExpertise { get; set; }
        public virtual DbSet<C_EmployeeLanguage> C_EmployeeLanguage { get; set; }
        public virtual DbSet<C_EmployeeOrganization> C_EmployeeOrganization { get; set; }
        public virtual DbSet<C_EmployeeReference> C_EmployeeReference { get; set; }
        public virtual DbSet<C_EmployeeRelative> C_EmployeeRelative { get; set; }
        public virtual DbSet<C_EmployeeTraining> C_EmployeeTraining { get; set; }
        public virtual DbSet<C_Grade> C_Grade { get; set; }
        public virtual DbSet<C_GroupData> C_GroupData { get; set; }
        public virtual DbSet<C_Holiday> C_Holiday { get; set; }
        public virtual DbSet<C_JamSosTek> C_JamSosTek { get; set; }
        public virtual DbSet<C_Job> C_Job { get; set; }
        public virtual DbSet<C_JobTitle> C_JobTitle { get; set; }
        public virtual DbSet<C_Leave> C_Leave { get; set; }
        public virtual DbSet<C_LeaveDetail> C_LeaveDetail { get; set; }
        public virtual DbSet<C_LNDTopic> C_LNDTopic { get; set; }
        public virtual DbSet<C_LNDTopicGroup> C_LNDTopicGroup { get; set; }
        public virtual DbSet<C_MinimumWageRegional> C_MinimumWageRegional { get; set; }
        public virtual DbSet<C_MinimumWageRegionalDetail> C_MinimumWageRegionalDetail { get; set; }
        public virtual DbSet<C_NomorReport1721A1> C_NomorReport1721A1 { get; set; }
        public virtual DbSet<C_NPPJamsostek> C_NPPJamsostek { get; set; }
        public virtual DbSet<C_Organization> C_Organization { get; set; }
        public virtual DbSet<C_OrganizationYear> C_OrganizationYear { get; set; }
        public virtual DbSet<C_OutputFile> C_OutputFile { get; set; }
        public virtual DbSet<C_OutputFileDetail> C_OutputFileDetail { get; set; }
        public virtual DbSet<C_OverTime> C_OverTime { get; set; }
        public virtual DbSet<C_OverTimeDetail> C_OverTimeDetail { get; set; }
        public virtual DbSet<C_OverTimeGroupOverTime> C_OverTimeGroupOverTime { get; set; }
        public virtual DbSet<C_OverTimeGroupTag> C_OverTimeGroupTag { get; set; }
        public virtual DbSet<C_PaymentSchedule> C_PaymentSchedule { get; set; }
        public virtual DbSet<C_PaySlipField> C_PaySlipField { get; set; }
        public virtual DbSet<C_PaySlipFieldDetail> C_PaySlipFieldDetail { get; set; }
        public virtual DbSet<C_PaySlipFieldDetailComponent> C_PaySlipFieldDetailComponent { get; set; }
        public virtual DbSet<C_PPH21> C_PPH21 { get; set; }
        public virtual DbSet<C_ReplacementDO> C_ReplacementDO { get; set; }
        public virtual DbSet<C_ReplacementDODetail> C_ReplacementDODetail { get; set; }
        public virtual DbSet<C_Report> C_Report { get; set; }
        public virtual DbSet<C_ResignationType> C_ResignationType { get; set; }
        public virtual DbSet<C_ROGroupTag> C_ROGroupTag { get; set; }
        public virtual DbSet<C_Roster> C_Roster { get; set; }
        public virtual DbSet<C_RosterOverTimeDetail> C_RosterOverTimeDetail { get; set; }
        public virtual DbSet<C_RosterRODetail> C_RosterRODetail { get; set; }
        public virtual DbSet<C_RoundingOvertime> C_RoundingOvertime { get; set; }
        public virtual DbSet<C_RoundingReplacementDO> C_RoundingReplacementDO { get; set; }
        public virtual DbSet<C_SalaryComponent> C_SalaryComponent { get; set; }
        public virtual DbSet<C_SalaryComponentAttendanceCode> C_SalaryComponentAttendanceCode { get; set; }
        public virtual DbSet<C_SalaryComponentDetail> C_SalaryComponentDetail { get; set; }
        public virtual DbSet<C_SalaryComponentEmployee> C_SalaryComponentEmployee { get; set; }
        public virtual DbSet<C_SalaryComponentLengthOfService> C_SalaryComponentLengthOfService { get; set; }
        public virtual DbSet<C_SalaryComponentTag> C_SalaryComponentTag { get; set; }
        public virtual DbSet<C_SettingMandatoryField> C_SettingMandatoryField { get; set; }
        public virtual DbSet<C_Severance> C_Severance { get; set; }
        public virtual DbSet<C_SeveranceMeritPay> C_SeveranceMeritPay { get; set; }
        public virtual DbSet<C_SPTMasa> C_SPTMasa { get; set; }
        public virtual DbSet<C_SPTMasaDetail> C_SPTMasaDetail { get; set; }
        public virtual DbSet<C_SystemInfo> C_SystemInfo { get; set; }
        public virtual DbSet<C_SystemPolling> C_SystemPolling { get; set; }
        public virtual DbSet<C_Tag> C_Tag { get; set; }
        public virtual DbSet<C_Tax> C_Tax { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<C_UserDetail> C_UserDetail { get; set; }
        public virtual DbSet<C_UserGroup> C_UserGroup { get; set; }
        public virtual DbSet<C_UserProfile> C_UserProfile { get; set; }
        public virtual DbSet<C_UserProfileDetail> C_UserProfileDetail { get; set; }
        public virtual DbSet<C_UserProfileFind> C_UserProfileFind { get; set; }
        public virtual DbSet<C_Version> C_Version { get; set; }
        public virtual DbSet<C_WorkGroup> C_WorkGroup { get; set; }
        public virtual DbSet<C_WorkingPattern> C_WorkingPattern { get; set; }
        public virtual DbSet<C_WorkingPatternDetail> C_WorkingPatternDetail { get; set; }
        public virtual DbSet<C_WorkingShift> C_WorkingShift { get; set; }
        public virtual DbSet<AppraisalRequest> AppraisalRequests { get; set; }
        public virtual DbSet<AppraisalRequestComment> AppraisalRequestComments { get; set; }
        public virtual DbSet<AppraisalRequestCompetencyCore> AppraisalRequestCompetencyCores { get; set; }
        public virtual DbSet<AppraisalRequestKPI> AppraisalRequestKPIs { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<ClaimAdjustment> ClaimAdjustments { get; set; }
        public virtual DbSet<ClaimExtension> ClaimExtensions { get; set; }
        public virtual DbSet<ClaimExtensionDetail> ClaimExtensionDetails { get; set; }
        public virtual DbSet<ClaimRequest> ClaimRequests { get; set; }
        public virtual DbSet<ClaimRequestDetail> ClaimRequestDetails { get; set; }
        public virtual DbSet<EmployeeTransaction> EmployeeTransactions { get; set; }
        public virtual DbSet<EmployeeTransfer> EmployeeTransfers { get; set; }
        public virtual DbSet<EmployeeTransferDetail> EmployeeTransferDetails { get; set; }
        public virtual DbSet<LeaveAdjustment> LeaveAdjustments { get; set; }
        public virtual DbSet<LeaveCompensation> LeaveCompensations { get; set; }
        public virtual DbSet<LeaveCompensationDetail> LeaveCompensationDetails { get; set; }
        public virtual DbSet<LeaveExtension> LeaveExtensions { get; set; }
        public virtual DbSet<LeaveExtensionDetail> LeaveExtensionDetails { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }
        public virtual DbSet<LND> LNDs { get; set; }
        public virtual DbSet<LNDActionPlan> LNDActionPlans { get; set; }
        public virtual DbSet<LNDAspectAction> LNDAspectActions { get; set; }
        public virtual DbSet<LNDAspectTopic> LNDAspectTopics { get; set; }
        public virtual DbSet<LNDCoach> LNDCoaches { get; set; }
        public virtual DbSet<LNDLastTopic> LNDLastTopics { get; set; }
        public virtual DbSet<LNDObjective> LNDObjectives { get; set; }
        public virtual DbSet<LNDPlanning> LNDPlannings { get; set; }
        public virtual DbSet<LNDPlanningDetail> LNDPlanningDetails { get; set; }
        public virtual DbSet<LNDPreparation> LNDPreparations { get; set; }
        public virtual DbSet<LNDReview> LNDReviews { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<LoanDetail> LoanDetails { get; set; }
        public virtual DbSet<NotaDina> NotaDinas { get; set; }
        public virtual DbSet<NotaDinasCC> NotaDinasCCs { get; set; }
        public virtual DbSet<NotaDinasDocument> NotaDinasDocuments { get; set; }
        public virtual DbSet<NotaDinasEmployee> NotaDinasEmployees { get; set; }
        public virtual DbSet<NotaDinasEmployeeDate> NotaDinasEmployeeDates { get; set; }
        public virtual DbSet<OvertimeRequest> OvertimeRequests { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PensionFund> PensionFunds { get; set; }
        public virtual DbSet<PensionFundDetail> PensionFundDetails { get; set; }
        public virtual DbSet<PermitRequest> PermitRequests { get; set; }
        public virtual DbSet<ProcessQueue> ProcessQueues { get; set; }
        public virtual DbSet<ProcessQueueDetail> ProcessQueueDetails { get; set; }
        public virtual DbSet<Resignation> Resignations { get; set; }
        public virtual DbSet<ResignationBranchAsset> ResignationBranchAssets { get; set; }
        public virtual DbSet<ResignationDetail> ResignationDetails { get; set; }
        public virtual DbSet<RollBackTransaction> RollBackTransactions { get; set; }
        public virtual DbSet<RORequest> RORequests { get; set; }
        public virtual DbSet<SalaryAdjustment> SalaryAdjustments { get; set; }
        public virtual DbSet<SalaryAdjustmentDetail> SalaryAdjustmentDetails { get; set; }
        public virtual DbSet<SalaryAdjustmentGlobal> SalaryAdjustmentGlobals { get; set; }
        public virtual DbSet<SalaryAdjustmentGlobalDetail> SalaryAdjustmentGlobalDetails { get; set; }
        public virtual DbSet<SalaryEmployee> SalaryEmployees { get; set; }
        public virtual DbSet<SalaryEmployeeCustom> SalaryEmployeeCustoms { get; set; }
        public virtual DbSet<SalaryEmployeePayment> SalaryEmployeePayments { get; set; }
        public virtual DbSet<SalaryReductionUnReduction> SalaryReductionUnReductions { get; set; }
        public virtual DbSet<StatusAlteration> StatusAlterations { get; set; }
        public virtual DbSet<TaxStatusAlteration> TaxStatusAlterations { get; set; }
        public virtual DbSet<TaxStatusAlterationDetail> TaxStatusAlterationDetails { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<TrainingAnswer> TrainingAnswers { get; set; }
        public virtual DbSet<TrainingDetail> TrainingDetails { get; set; }
        public virtual DbSet<TrainingQuestion> TrainingQuestions { get; set; }
        public virtual DbSet<UserActivity> UserActivities { get; set; }
        public virtual DbSet<Warning> Warnings { get; set; }
        public virtual DbSet<C_AutoNumber> C_AutoNumber { get; set; }
        public virtual DbSet<C_AutoNumberDetail> C_AutoNumberDetail { get; set; }
        public virtual DbSet<C_AutoNumberPool> C_AutoNumberPool { get; set; }
        public virtual DbSet<C_AutoNumberPoolDetail> C_AutoNumberPoolDetail { get; set; }
        public virtual DbSet<C_Company> C_Company { get; set; }
        public virtual DbSet<C_Provider> C_Provider { get; set; }
        public virtual DbSet<C_ReportTemplate> C_ReportTemplate { get; set; }
        public virtual DbSet<C_ResignationMatrix> C_ResignationMatrix { get; set; }
        public virtual DbSet<C_SystemStatus> C_SystemStatus { get; set; }
        public virtual DbSet<C_UserProfileCustomFind> C_UserProfileCustomFind { get; set; }
        public virtual DbSet<AttendanceMachine> AttendanceMachines { get; set; }
        public virtual DbSet<MaintenanceLog> MaintenanceLogs { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ResourcesCenter> ResourcesCenters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C__Employee>()
                .Property(e => e.BasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.BasicSalaryComponentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.EBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.JamSosTekNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.BPJSNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.PensionNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__Employee>()
                .Property(e => e.PensionFundNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__EmployeeSalaryComponent>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C__EmployeeSalaryComponent>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C__EmployeeSalaryComponent>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__EmployeeSalaryComponent>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.PermitLeaveOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.PermitLeaveOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOnHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOffHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOffBreakHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLOnBreakHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.DutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.DutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.BreakOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.BreakInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.WorkHourInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.WorkHourOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualDutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualDutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualBreakOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualBreakInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.LateIn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.EarlyOut)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.WorkingHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.SPLDeductionBreak)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualWorkingHour)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C__Roster>()
                .Property(e => e.ActualDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryComponent>()
                .Property(e => e.EmployeeFormula)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PensionFundNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PensionNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.JamSosTekNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBAJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBDJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBackPayBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBackPayOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBackPayAllowanceDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RResignationAddition)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RResignationDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ROverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RAllowanceOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RDeductionOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RLeave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RLoan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RClaim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJKK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJPK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJKM)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJHTEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJHTComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RPensionComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RPensionEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RPensionFund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RPensionFundComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RPensionFundEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.BiayaJabatan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBruto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PKP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PTKP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.BiayaJabatanOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PKPOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PTKPOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GClaim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GLeave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GSalaryNetto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GReduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GBackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GResignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.Period)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PaymentPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBAPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBDPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GBegBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.GBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBPension)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoOtherYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRAllowanceOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRDeductionOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.LastGTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.DiffGTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.BegRSalaryNetto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.BegRPPH21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RCBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRBackPayBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.FRBackPayAllowanceDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryNettoYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBSalaryNettoOtherYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTekPlus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTekMinus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBPensionMinus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBOverTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBAJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBDJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBackPayBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBackPayOverTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBackPayAllowanceDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERResignationAddition)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERResignationDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EROverTime)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERAllowanceOnce)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERDeductionOnce)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERLeave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJKK)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJPK)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJKM)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJHTEmp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJHTComp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERPensionComp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERPensionEmp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERPensionFundComp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERPensionFundEmp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBAPension)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBDPension)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRAllowanceOnce)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRDeductionOnce)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERCBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRBackPayBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EFRBackPayAllowanceDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTekPlus)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTekMinus)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBPensionMinus)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGOnce)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGClaim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGLeave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGSalaryNetto)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGBackPay)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGResignation)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ELastGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoOther)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBruto)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryNettoYear)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryNettoOtherYear)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPKP)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPKPOther)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBPJSComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBPJSEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBABPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBDBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.BPJSNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RBPJSFamily)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBBPJS)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBPJSComp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBPJSEmp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBABPJS)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBDBPJS)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBPJSFamily)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJPComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.RJPEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJPComp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERJPEmp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERClaim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EBiayaJabatan)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EBiayaJabatanOther)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoYear)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoOtherYear)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGbalance)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGBegBalance)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EBegRPPH21)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EBegRSalaryNetto)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EGReduction)
                .IsUnicode(false);

            modelBuilder.Entity<C__SalaryEmployeePayment>()
                .Property(e => e.EDiffGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<C__UserPassword>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournal>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournal>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_AccountJournal>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournal>()
                .HasMany(e => e.C_AccountJournalDetail)
                .WithRequired(e => e.C_AccountJournal)
                .HasForeignKey(e => e.AccountJournalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_AccountJournalCostCenter>()
                .Property(e => e.CostCenterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournalDetail>()
                .Property(e => e.SalaryComponentName)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournalDetail>()
                .Property(e => e.SalaryComponentDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_AccountJournalDetail>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_AttachmentImage>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<C_AttendanceCode>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_AttendanceCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_AttendanceType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_AttendanceType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.DevidedByAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.MultipleAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.DividerAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_BaseRate>()
                .Property(e => e.FormulaAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_BaseRate>()
                .HasMany(e => e.C_BaseRateDetail)
                .WithRequired(e => e.C_BaseRate)
                .HasForeignKey(e => e.BaseRateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_BlackListIdNumber>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_BlackListIdNumber>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_BlackListIdNumber>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.NPWP)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.CoreBusiness)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Director)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.NPWPTaxPerson)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.TaxPerson)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.KluCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.KPJNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.ExtraData)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.TaxPersonPosition)
                .IsUnicode(false);

            modelBuilder.Entity<C_Branch>()
                .Property(e => e.EFin)
                .IsUnicode(false);

            modelBuilder.Entity<C_BranchAsset>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_BranchAsset>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_BranchAsset>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_BranchAsset>()
                .HasMany(e => e.C_EmployeeBranchAsset)
                .WithOptional(e => e.C_BranchAsset)
                .HasForeignKey(e => e.BranchAssetId);

            modelBuilder.Entity<C_Break>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Break>()
                .HasMany(e => e.C_BreakDetail)
                .WithRequired(e => e.C_Break)
                .HasForeignKey(e => e.BreakId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_BreakDetail>()
                .Property(e => e.BreakIn)
                .IsUnicode(false);

            modelBuilder.Entity<C_BreakDetail>()
                .Property(e => e.BreakOut)
                .IsUnicode(false);

            modelBuilder.Entity<C_BreakDetail>()
                .Property(e => e.TotalHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Calendar>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Calendar>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Calendar>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Calendar>()
                .HasMany(e => e.C_CalendarDetail)
                .WithOptional(e => e.C_Calendar)
                .HasForeignKey(e => e.CalendarId);

            modelBuilder.Entity<C_CalendarDetail>()
                .Property(e => e.DutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_CalendarDetail>()
                .Property(e => e.DutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_CalendarDetail>()
                .Property(e => e.BreakInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_CalendarDetail>()
                .Property(e => e.BreakOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_CalendarDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CashTransferField>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CashTransferField>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CashTransferField>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_CashTransferFieldDetail>()
                .Property(e => e.SalaryComponentName)
                .IsUnicode(false);

            modelBuilder.Entity<C_CashTransferFieldDetail>()
                .Property(e => e.SalaryComponentDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_CashTransferFieldDetail>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.AmountFormula)
                .IsUnicode(false);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Claim>()
                .Property(e => e.AmountDependent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Claim>()
                .HasMany(e => e.C_ClaimDetail)
                .WithRequired(e => e.C_Claim)
                .HasForeignKey(e => e.ClaimId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_ClaimDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_ClaimDetail>()
                .Property(e => e.FormulaBenefit)
                .IsUnicode(false);

            modelBuilder.Entity<C_Class>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Class>()
                .Property(e => e.FromAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Class>()
                .Property(e => e.ToAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Class>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Class>()
                .Property(e => e.MidAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Competency>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyAppraisal)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyBranch)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyCore)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyFinalResult)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyGrade)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyJobResult)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyKPI)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Competency>()
                .HasMany(e => e.C_CompetencyKPIResult)
                .WithRequired(e => e.C_Competency)
                .HasForeignKey(e => e.CompetencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyAppraisal>()
                .Property(e => e.KPI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyAppraisal>()
                .Property(e => e.CompetencyCore)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyAppraisal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyAppraisal>()
                .HasMany(e => e.C_CompetencyCoreAppraisal)
                .WithRequired(e => e.C_CompetencyAppraisal)
                .HasForeignKey(e => e.CompetencyAppraisalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyAppraisal>()
                .HasMany(e => e.C_CompetencyJob)
                .WithRequired(e => e.C_CompetencyAppraisal)
                .HasForeignKey(e => e.CompetencyAppraisalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .HasMany(e => e.C_CompetencyCoreKeyAction)
                .WithRequired(e => e.C_CompetencyCore)
                .HasForeignKey(e => e.CompetencyCoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .HasMany(e => e.C_CompetencyCoreAppraisal)
                .WithRequired(e => e.C_CompetencyCore)
                .HasForeignKey(e => e.CompetencyCoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .HasMany(e => e.C_CompetencyCoreGrade)
                .WithRequired(e => e.C_CompetencyCore)
                .HasForeignKey(e => e.CompetencyCoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyCore>()
                .HasMany(e => e.C_CompetencyCoreScale)
                .WithRequired(e => e.C_CompetencyCore)
                .HasForeignKey(e => e.CompetencyCoreId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyCoreAppraisal>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyCoreGrade>()
                .Property(e => e.Standard)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyCoreKeyAction>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyCoreScale>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyFinalResult>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyFinalResult>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyFinalResult>()
                .Property(e => e.MinimumAchievement)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyGrade>()
                .HasMany(e => e.C_CompetencyCoreGrade)
                .WithRequired(e => e.C_CompetencyGrade)
                .HasForeignKey(e => e.CompetencyGradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_CompetencyJobResult>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyKPI>()
                .Property(e => e.KeyResultArea)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyKPI>()
                .Property(e => e.KPI)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyKPI>()
                .Property(e => e.TrackingSource)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyKPI>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CompetencyKPIResult>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CompetencyKPIResult>()
                .Property(e => e.MinimumAchievement)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasActivityDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.AirPortTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.MealDayOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.DayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.MealWorkingDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_CostNotaDinasDetailTypeSchedule>()
                .Property(e => e.MealDayOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetailTypeSchedule>()
                .Property(e => e.MealWorkingDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetailTypeTransport>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CostNotaDinasDetailTypeTransport>()
                .Property(e => e.AirPortTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CurrencyRate>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CurrencyRate>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_CustomField>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<C_CustomFieldDefinition>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_CustomFieldDefinition>()
                .Property(e => e.CustomFieldGroup)
                .IsUnicode(false);

            modelBuilder.Entity<C_CustomFieldDefinition>()
                .HasMany(e => e.C_CustomField)
                .WithOptional(e => e.C_CustomFieldDefinition)
                .HasForeignKey(e => e.CustomFieldDefinitionId);

            modelBuilder.Entity<C_CustomFieldHistory>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<C_DropDownItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_DropDownItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_DropDownItem>()
                .HasMany(e => e.C_DropDownItemDetail)
                .WithRequired(e => e.C_DropDownItem)
                .HasForeignKey(e => e.DropDownItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_DropDownItemDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.HandPhone)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Hobby)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.PointOfHire)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.NPWP)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Contact1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Contact2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.PlaceOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Ethnic)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.IdNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.DrivingLicenseA)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.DrivingLicenseB)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.DrivingLicenseC)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.DrivingLicenseB1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.DrivingLicenseB2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.BasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.PensionFundNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.PensionNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.JamSosTekNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.EBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.BegRSalaryNetto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.BegRPPH21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.PhoneExtension)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.BPJSNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.KITAS)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.FamilyCardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.City1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.City2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.ZipCode1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.ZipCode2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .Property(e => e.EmailPayslip)
                .IsUnicode(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C__Employee)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeCostCenter)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeDependent)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeEducation)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeExpertise)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeLanguage)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeOrganization)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeReference)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeRelative)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.C_EmployeeTraining)
                .WithRequired(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.LeaveRequests)
                .WithOptional(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.Resignations)
                .WithOptional(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<C_Employee>()
                .HasMany(e => e.SalaryEmployees)
                .WithOptional(e => e.C_Employee)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeBank>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeCC>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeCostCenter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeCostCenter>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.PlaceOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.HandPhone)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Ethnic)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.NPWP)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDependent>()
                .Property(e => e.IdNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDocument>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeDocument>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEducation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEducation>()
                .Property(e => e.StartYear)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEducation>()
                .Property(e => e.EndYear)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEducation>()
                .Property(e => e.GPA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeEducation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.Planning)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.Claimed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.ETotal)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.EPlanning)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeEmergeClaim>()
                .Property(e => e.EClaimed)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeExperience>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeExperience>()
                .Property(e => e.LastPosition)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeExperience>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeExperience>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeExpertise>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeLanguage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeOrganization>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeOrganization>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeOrganization>()
                .Property(e => e.FromYear)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeOrganization>()
                .Property(e => e.ToYear)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeReference>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeReference>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeReference>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeReference>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeRelative>()
                .Property(e => e.Relation)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.Organizer)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.Duration)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.TrainingFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_EmployeeTraining>()
                .Property(e => e.Rating)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Grade>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Grade>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Grade>()
                .HasMany(e => e.C_Class)
                .WithRequired(e => e.C_Grade)
                .HasForeignKey(e => e.GradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_GroupData>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_GroupData>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Holiday>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JKK1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JKK2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JKK3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JKK4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JKK5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JHTComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JHTEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JPK1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JPK2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.MaxJPK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.PensionComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.PensionEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.PensionFund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.MaxPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.BPJSComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.BPJSEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.MaxBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.BPJSFamily)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JPEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.JPComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.UseOtherPensionOrganizer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_JamSosTek>()
                .Property(e => e.MaxJP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Job>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Job>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Job>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<C_Job>()
                .Property(e => e.CostCenterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_Job>()
                .HasMany(e => e.EmployeeTransfers)
                .WithOptional(e => e.C_Job)
                .HasForeignKey(e => e.FromJobId);

            modelBuilder.Entity<C_Job>()
                .HasMany(e => e.EmployeeTransfers1)
                .WithOptional(e => e.C_Job1)
                .HasForeignKey(e => e.ToJobId);

            modelBuilder.Entity<C_JobTitle>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_JobTitle>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Leave>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Leave>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Leave>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Leave>()
                .Property(e => e.AmountFormula)
                .IsUnicode(false);

            modelBuilder.Entity<C_Leave>()
                .HasMany(e => e.C_LeaveDetail)
                .WithRequired(e => e.C_Leave)
                .HasForeignKey(e => e.LeaveId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_Leave>()
                .HasMany(e => e.LeaveAdjustments)
                .WithOptional(e => e.C_Leave)
                .HasForeignKey(e => e.LeaveCodeId);

            modelBuilder.Entity<C_LNDTopic>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_LNDTopic>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_LNDTopic>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_LNDTopicGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_LNDTopicGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_MinimumWageRegional>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_MinimumWageRegional>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_MinimumWageRegionalDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_NomorReport1721A1>()
                .Property(e => e.Tahun)
                .IsUnicode(false);

            modelBuilder.Entity<C_NomorReport1721A1>()
                .Property(e => e.NomorReport)
                .IsUnicode(false);

            modelBuilder.Entity<C_NPPJamsostek>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_NPPJamsostek>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_NPPJamsostek>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.LineOfBusiness)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .Property(e => e.CostCenterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_Organization>()
                .HasMany(e => e.EmployeeTransfers)
                .WithOptional(e => e.C_Organization)
                .HasForeignKey(e => e.FromOrganizationId);

            modelBuilder.Entity<C_Organization>()
                .HasMany(e => e.EmployeeTransfers1)
                .WithOptional(e => e.C_Organization1)
                .HasForeignKey(e => e.ToOrganizationId);

            modelBuilder.Entity<C_OrganizationYear>()
                .Property(e => e.LNDBudgetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_OutputFile>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_OutputFile>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_OutputFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<C_OutputFile>()
                .HasMany(e => e.C_OutputFileDetail)
                .WithRequired(e => e.C_OutputFile)
                .HasForeignKey(e => e.OutputFileId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_OutputFileDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_OutputFileDetail>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<C_OutputFileDetail>()
                .Property(e => e.PaddingChar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_OverTime>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_OverTime>()
                .HasMany(e => e.C_OverTimeDetail)
                .WithRequired(e => e.C_OverTime)
                .HasForeignKey(e => e.OverTimeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_OverTimeDetail>()
                .Property(e => e.FromHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_OverTimeDetail>()
                .Property(e => e.ToHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_OverTimeDetail>()
                .Property(e => e.Multiply)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_PaymentSchedule>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaymentSchedule>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaymentSchedule>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_PaymentSchedule>()
                .HasMany(e => e.C_SalaryComponent)
                .WithOptional(e => e.C_PaymentSchedule)
                .HasForeignKey(e => e.PaymentScheduleId);

            modelBuilder.Entity<C_PaySlipField>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaySlipField>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaySlipField>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_PaySlipFieldDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaySlipFieldDetailComponent>()
                .Property(e => e.SalaryComponentName)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaySlipFieldDetailComponent>()
                .Property(e => e.SalaryComponentDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_PaySlipFieldDetailComponent>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_PPH21>()
                .Property(e => e.FromAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_PPH21>()
                .Property(e => e.ToAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_PPH21>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_ReplacementDO>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_ReplacementDO>()
                .HasMany(e => e.C_ReplacementDODetail)
                .WithRequired(e => e.C_ReplacementDO)
                .HasForeignKey(e => e.ReplacementDOId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_ReplacementDODetail>()
                .Property(e => e.FromHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_ReplacementDODetail>()
                .Property(e => e.ToHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_ReplacementDODetail>()
                .Property(e => e.Multiply)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Report>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Report>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<C_Report>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_ResignationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_ResignationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_ResignationType>()
                .HasMany(e => e.Resignations)
                .WithOptional(e => e.C_ResignationType)
                .HasForeignKey(e => e.ResignationTypeId);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.PermitLeaveOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.PermitLeaveOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOnHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOffHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOffBreakHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLOnBreakHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLHourPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.DutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.DutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.BreakOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.BreakInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.WorkHourInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.WorkHourOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualDutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualDutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualBreakOutTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualBreakInTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.LateIn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.EarlyOut)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.WorkingHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualBreakHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.SPLDeductionBreak)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualSPLHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualWorkingHour)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Roster>()
                .Property(e => e.ActualDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.Hour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.Multiply)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.BasicOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.BasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.EBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.EBasicOverTime)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterOverTimeDetail>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.Hour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.Multiply)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.BasicRO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.BasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.EBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.EBasicRO)
                .IsUnicode(false);

            modelBuilder.Entity<C_RosterRODetail>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_RoundingOvertime>()
                .Property(e => e.MinuteOvertime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RoundingOvertime>()
                .Property(e => e.MinuteRounding)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RoundingReplacementDO>()
                .Property(e => e.MinuteReplacementDO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_RoundingReplacementDO>()
                .Property(e => e.MinuteRounding)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.EmployeeFormula)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.EmployeeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.EEmployeeAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .HasMany(e => e.C_BaseRateDetail)
                .WithOptional(e => e.C_SalaryComponent)
                .HasForeignKey(e => e.SalaryComponentId);

            modelBuilder.Entity<C_SalaryComponent>()
                .HasMany(e => e.C_SalaryComponentAttendanceCode)
                .WithRequired(e => e.C_SalaryComponent)
                .HasForeignKey(e => e.SalaryComponentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .HasMany(e => e.C_SalaryComponentDetail)
                .WithRequired(e => e.C_SalaryComponent)
                .HasForeignKey(e => e.SalaryComponentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .HasMany(e => e.C_SalaryComponentEmployee)
                .WithRequired(e => e.C_SalaryComponent)
                .HasForeignKey(e => e.SalaryComponentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_SalaryComponent>()
                .HasMany(e => e.C_SalaryComponentLengthOfService)
                .WithRequired(e => e.C_SalaryComponent)
                .HasForeignKey(e => e.SalaryComponentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_SalaryComponentDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SalaryComponentDetail>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponentEmployee>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SalaryComponentEmployee>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_SalaryComponentLengthOfService>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SalaryComponentLengthOfService>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<C_SettingMandatoryField>()
                .Property(e => e.NamaTable)
                .IsUnicode(false);

            modelBuilder.Entity<C_SettingMandatoryField>()
                .Property(e => e.NamaField)
                .IsUnicode(false);

            modelBuilder.Entity<C_Severance>()
                .Property(e => e.FromAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Severance>()
                .Property(e => e.ToAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Severance>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SeveranceMeritPay>()
                .Property(e => e.Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SeveranceMeritPay>()
                .Property(e => e.Pension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SeveranceMeritPay>()
                .Property(e => e.PassAway)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SeveranceMeritPay>()
                .Property(e => e.Others)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SPTMasa>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_SPTMasa>()
                .Property(e => e.ToName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SPTMasa>()
                .Property(e => e.PlaceName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SPTMasa>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<C_SPTMasa>()
                .Property(e => e.CityDate)
                .IsUnicode(false);

            modelBuilder.Entity<C_SPTMasa>()
                .HasMany(e => e.C_SPTMasaDetail)
                .WithRequired(e => e.C_SPTMasa)
                .HasForeignKey(e => e.SPTMasaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_SPTMasaDetail>()
                .Property(e => e.SalaryBruto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_SPTMasaDetail>()
                .Property(e => e.PPH21)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.MinDenominator)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ActiveDirectoryDomain)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.SMTPServer)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.SMTPUserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.SMTPPassword)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.SMTPAdminEmail)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipSubject)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipBody)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipResetSubject)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipResetBody)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipInvitationSubject)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.ESlipInvitationBody)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.BackupLocation)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.NetworkProxy)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.NetworkUserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.NetworkPassword)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.DayOffDutyOn)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemInfo>()
                .Property(e => e.DayOffDutyOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DutyOn)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DutyOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DateSeparator)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DutyOnOffSeparator)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.OnOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.SeparatorChar)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.FrequencyStartingAt)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.FrequencyEndingAt)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.OnValue)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.OffValue)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.WebServiceMachine)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.WebServiceUserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.WebServicePassword)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DayOffDutyOn)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DayOffDutyOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.DateOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemPolling>()
                .Property(e => e.Sheet)
                .IsUnicode(false);

            modelBuilder.Entity<C_Tag>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Tag>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Tag>()
                .Property(e => e.BackColor)
                .IsUnicode(false);

            modelBuilder.Entity<C_Tag>()
                .HasMany(e => e.C_CalendarDetail)
                .WithOptional(e => e.C_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<C_Tag>()
                .HasMany(e => e.C_Holiday)
                .WithOptional(e => e.C_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<C_Tag>()
                .HasMany(e => e.C_OverTime)
                .WithOptional(e => e.C_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<C_Tag>()
                .HasMany(e => e.C_ReplacementDO)
                .WithOptional(e => e.C_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<C_Tag>()
                .HasMany(e => e.C_Roster)
                .WithOptional(e => e.C_Tag)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PTKPPribadi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PTKPIstri)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PTKPAnak)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.MaxBiayaJabatan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.BiayaJabatanPercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PPH21Expatriat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.MaxSalaryPem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.MaxDailyWage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.MinMonthlyWage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.MaxMonthlyWage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PPH21Wage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_Tax>()
                .Property(e => e.PPH21TenagaAhli)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .HasMany(e => e.C__UserPassword)
                .WithRequired(e => e.C_User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_UserGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfile>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfile>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfileFind>()
                .Property(e => e.ProfileName)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfileFind>()
                .Property(e => e.TransactionName)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfileFind>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingPattern>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingPattern>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingPattern>()
                .HasMany(e => e.C_Calendar)
                .WithOptional(e => e.C_WorkingPattern)
                .HasForeignKey(e => e.WorkingPatternId);

            modelBuilder.Entity<C_WorkingPattern>()
                .HasMany(e => e.C_WorkingPatternDetail)
                .WithRequired(e => e.C_WorkingPattern)
                .HasForeignKey(e => e.WorkingPatternId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.DutyOn)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.DutyOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.BreakOut)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.BreakIn)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.SPLOn)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.SPLOff)
                .IsUnicode(false);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.SPLBreakOnHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.SPLBreakOffHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_WorkingShift>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.TotalKPI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.PercentageKPI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.TotalCompetency)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.PercentageCompetency)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.ScoreKPI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.ScoreCompetency)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.PerformanceImprovement)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequest>()
                .Property(e => e.TrainingDevelopment)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequest>()
                .HasMany(e => e.AppraisalRequestComments)
                .WithRequired(e => e.AppraisalRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppraisalRequest>()
                .HasMany(e => e.AppraisalRequestCompetencyCores)
                .WithRequired(e => e.AppraisalRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppraisalRequest>()
                .HasMany(e => e.AppraisalRequestKPIs)
                .WithRequired(e => e.AppraisalRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppraisalRequestComment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestCompetencyCore>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestCompetencyCore>()
                .Property(e => e.StandardScale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestCompetencyCore>()
                .Property(e => e.Scale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestCompetencyCore>()
                .Property(e => e.Score)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestCompetencyCore>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.KeyResultArea)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.KPI)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.Scale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.Score)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.TrackingSource)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.MidYear)
                .IsUnicode(false);

            modelBuilder.Entity<AppraisalRequestKPI>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<Award>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Award>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Award>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClaimAdjustment>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimAdjustment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimAdjustment>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClaimExtension>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimExtension>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimExtension>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClaimExtension>()
                .HasMany(e => e.ClaimExtensionDetails)
                .WithRequired(e => e.ClaimExtension)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaimRequest>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimRequest>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClaimRequest>()
                .HasMany(e => e.ClaimRequestDetails)
                .WithRequired(e => e.ClaimRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaimRequestDetail>()
                .Property(e => e.Payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClaimRequestDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClaimRequestDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimRequestDetail>()
                .Property(e => e.HealthCareProvider)
                .IsUnicode(false);

            modelBuilder.Entity<ClaimRequestDetail>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTransfer>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTransfer>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTransfer>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeTransferDetail>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeaveAdjustment>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveAdjustment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveAdjustment>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveCompensation>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveCompensation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveCompensation>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveCompensationDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeaveExtension>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveExtension>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveExtension>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveExtension>()
                .HasMany(e => e.LeaveExtensionDetails)
                .WithRequired(e => e.LeaveExtension)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeaveRequest>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveRequest>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LND>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.TopicPlan)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Expense)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LND>()
                .Property(e => e.ProviderName)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.ProviderAddress)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.WorkGoals)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.ActualCondition)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.DevelopmentGoals)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Skill)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.Problem)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.EvaluationAction)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.EvaluationResult)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.TypeMethodDescription)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.TypeMethodNotes)
                .IsUnicode(false);

            modelBuilder.Entity<LND>()
                .Property(e => e.LNDTopicCostAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDActionPlans)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDAspectActions)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDAspectTopics)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDCoaches)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDLastTopics)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDObjectives)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDPreparations)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LND>()
                .HasMany(e => e.LNDReviews)
                .WithRequired(e => e.LND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LNDActionPlan>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LNDActionPlan>()
                .Property(e => e.Review)
                .IsUnicode(false);

            modelBuilder.Entity<LNDAspectAction>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LNDAspectAction>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LNDAspectTopic>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LNDAspectTopic>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LNDAspectTopic>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LNDCoach>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<LNDCoach>()
                .Property(e => e.Coach)
                .IsUnicode(false);

            modelBuilder.Entity<LNDLastTopic>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<LNDObjective>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanning>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanning>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanning>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LNDPlanning>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanning>()
                .HasMany(e => e.LNDPlanningDetails)
                .WithRequired(e => e.LNDPlanning)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.WorkGoals)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.ActualCondition)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.DevelopmentGoals)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.Skill)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.TypeMethodDescription)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPlanningDetail>()
                .Property(e => e.LNDTopicCostAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LNDPreparation>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPreparation>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPreparation>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<LNDPreparation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LNDReview>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<LNDReview>()
                .Property(e => e.FollowUp)
                .IsUnicode(false);

            modelBuilder.Entity<LNDReview>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<LNDReview>()
                .Property(e => e.Realization)
                .IsUnicode(false);

            modelBuilder.Entity<LNDReview>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.InterestRateYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.NumberOfInstallment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.PaymentPerInstallment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Loan>()
                .HasMany(e => e.LoanDetails)
                .WithRequired(e => e.Loan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.BeginningBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.BasicPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.Interest)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.TotalPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.RemainingLoan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.Paid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.BudgetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TaskNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TypeLocationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.CostNotaDinasActivityDetailDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.MealAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.MealFundDescripton)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayPayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FDayPayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayPayCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.DayRemainingAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FDayRemainingAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TransportFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.AirPortTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.AirPortTaxFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.OtherAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FOtherAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.OtherCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.OtherFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TicketAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FTicketAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TicketCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TicketFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FHotelAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.PassportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.PassportFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.VisaAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FVisaAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.VisaCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.VisaFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelTransitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FHotelTransitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelTransitCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.HotelTransitFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.InsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.FInsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.InsuranceCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.InsuranceFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NotaDina>()
                .Property(e => e.ActivityDate)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasDocument>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.MealAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.AirPortTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.DayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OMealDayOffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OMealWorkingDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.ODayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OFDayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OtherAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FOtherAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.TicketAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FTicketAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FHotelAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.PassportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.VisaAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FVisaAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelTransitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FHotelTransitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.InsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.FInsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OtherCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.OtherFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.TicketCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.TicketFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.PassportFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.VisaCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.VisaFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelTransitCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.HotelTransitFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.InsuranceCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotaDinasEmployee>()
                .Property(e => e.InsuranceFundDescription)
                .IsUnicode(false);

            modelBuilder.Entity<OvertimeRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Period)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.PaymentPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFund>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFund>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PensionFund>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PensionFund>()
                .HasMany(e => e.PensionFundDetails)
                .WithRequired(e => e.PensionFund)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PensionFundDetail>()
                .Property(e => e.Endowment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PensionFundDetail>()
                .Property(e => e.Term)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PermitRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessQueue>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessQueue>()
                .HasMany(e => e.ProcessQueueDetails)
                .WithRequired(e => e.ProcessQueue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.LeaveDay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.LeaveTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Bonus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.OthersDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.OthersAddition)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Gratuity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ClaimTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ClaimPercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeverancePayMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.MeritPayMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeverancePayTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeverancePay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.MeritPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.MeritPayTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Loan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Bank)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Training)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Cooperative)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.TravelAdvance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.Endowment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.TotalAddition)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.TotalDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ELeave)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ELeaveTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EBonus)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EClaim)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EClaimTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ESeverancePay)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EMeritPay)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EMeritPayTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ESeverancePayTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ETotalAddition)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EEndowment)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ETravelAdvance)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ECooperative)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ETraining)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EBank)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ELoan)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EGratuity)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EOthersAddition)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.EOthersDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ETotalDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeparationPayMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeparationPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.SeparationPayTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ESeparationPay)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .Property(e => e.ESeparationPayTotal)
                .IsUnicode(false);

            modelBuilder.Entity<Resignation>()
                .HasMany(e => e.ResignationDetails)
                .WithRequired(e => e.Resignation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResignationDetail>()
                .Property(e => e.BeginningBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ResignationDetail>()
                .Property(e => e.BasicPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ResignationDetail>()
                .Property(e => e.TotalPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ResignationDetail>()
                .Property(e => e.RemainingInstallment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RORequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.OldBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.NewBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.ENewBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustment>()
                .Property(e => e.EOldBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentDetail>()
                .Property(e => e.OldAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustmentDetail>()
                .Property(e => e.NewAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustmentDetail>()
                .Property(e => e.EOldAmount)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentDetail>()
                .Property(e => e.ENewAmount)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentGlobal>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentGlobal>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentGlobal>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalaryAdjustmentGlobal>()
                .Property(e => e.EmployeeFormula)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentGlobal>()
                .HasMany(e => e.SalaryAdjustmentGlobalDetails)
                .WithRequired(e => e.SalaryAdjustmentGlobal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryAdjustmentGlobalDetail>()
                .Property(e => e.OldAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustmentGlobalDetail>()
                .Property(e => e.NewAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryAdjustmentGlobalDetail>()
                .Property(e => e.EOldAmount)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryAdjustmentGlobalDetail>()
                .Property(e => e.ENewAmount)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployee>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployee>()
                .Property(e => e.EAmount)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployee>()
                .Property(e => e.CurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SMEALALLOWANCE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANBPJSKESEHATAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANJABATAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANJHT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANJP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANLAIN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANRUMAH)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANTRANSPORT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SLEMBURMIDNIGHTSALES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SUNPAIDLEAVE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.CSTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.Sswda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.Sswdp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANLAINGROSS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STUNJANGANLAINGROSSUP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SDASARBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SBPJSMINUS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SSeverance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.CSSeverance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STunjanganBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.SMEALALLOWANCEGROSSUP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STHRGROSS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.CSTHRGROSS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.STHRGROSSUP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeeCustom>()
                .Property(e => e.CSTHRGROSSUP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PensionFundNo)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PensionNo)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.JamSosTekNo)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBAJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBDJamSosTek)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBackPayBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBackPayOverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBackPayAllowanceDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RResignationAddition)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RResignationDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ROverTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RAllowanceOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RDeductionOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RLeave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RLoan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RClaim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJKK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJPK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJKM)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJHTEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJHTComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RPensionComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RPensionEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RPensionFund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RPensionFundComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RPensionFundEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.BiayaJabatan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBruto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PKP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PTKP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.BiayaJabatanOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PKPOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PTKPOther)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.TunjPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GClaim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GLeave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GSalaryNetto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GReduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GBackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GResignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.Period)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PaymentPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBAPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBDPension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.PemPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GBegBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.GBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBPension)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryBrutoOtherYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRAllowanceOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRDeductionOnce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRBonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.LastGTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.DiffGTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.BegRSalaryNetto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.BegRPPH21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RCBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21BackPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Emp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Once)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21BonusTHR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Claim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Leave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.CompPPH21Resignation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRBackPayBasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.FRBackPayAllowanceDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RCurrencyRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryNettoYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBSalaryNettoOtherYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTekPlus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBJamSosTekMinus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBPensionMinus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBOverTime)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBAJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBDJamSosTek)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBackPayBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBackPayOverTime)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBackPayAllowanceDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERResignationAddition)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERResignationDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EROverTime)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERAllowanceOnce)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERDeductionOnce)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERLeave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJKK)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJPK)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJKM)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJHTEmp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJHTComp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERPensionComp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERPensionEmp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERPensionFundComp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERPensionFundEmp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBAPension)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBDPension)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRAllowance)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRAllowanceOnce)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRDeductionOnce)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERCBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRBackPayBasicSalary)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EFRBackPayAllowanceDeduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTekPlus)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBJamSosTekMinus)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBPensionMinus)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGOnce)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGBonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGClaim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGLeave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGSalaryNetto)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGBackPay)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGResignation)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ELastGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoOther)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBruto)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryNettoYear)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryNettoOtherYear)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPKP)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPKPOther)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBPJSComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBPJSEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBABPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBDBPJS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.BPJSNo)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RBPJSFamily)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBBPJS)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBPJSComp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBPJSEmp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBABPJS)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBDBPJS)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBPJSFamily)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJPComp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.RJPEmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJPComp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERJPEmp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERClaim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EBiayaJabatan)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EBiayaJabatanOther)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoYear)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ERBSalaryBrutoOtherYear)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ETunjPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.ECompPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Total)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21BackPay)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Resignation)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Emp)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Once)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21BonusTHR)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Claim)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EPemPPH21Leave)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGbalance)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGBegBalance)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EBegRPPH21)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EBegRSalaryNetto)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EGReduction)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryEmployeePayment>()
                .Property(e => e.EDiffGTotal)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.ReductionAmountPercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.ReductionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.UnReductionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.UnReductionBy)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.ReductionBy)
                .IsUnicode(false);

            modelBuilder.Entity<SalaryReductionUnReduction>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StatusAlteration>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<StatusAlteration>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<StatusAlteration>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaxStatusAlteration>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Training>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.SubjectOfTraining)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.HRDGAManager)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.TrainingInstitution)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Venue)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.TrainingFee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Training>()
                .Property(e => e.DepartmentManager)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.VPM)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.FASupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.CurrencyName)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.AccountHolder)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.BankBranch)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.HRDSuperintendent)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.MemoTo)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingAnswer>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.FromDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.ToDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.TypeOfTransportation)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingDetail>()
                .Property(e => e.ArrangementBy)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingQuestion>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivity>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivity>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivity>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivity>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivity>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<Warning>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Warning>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Warning>()
                .Property(e => e.AutoNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_AutoNumber>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_AutoNumberDetail>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_AutoNumberPool>()
                .Property(e => e.UpdateStamp)
                .IsFixedLength();

            modelBuilder.Entity<C_AutoNumberPool>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_AutoNumberPoolDetail>()
                .Property(e => e.UpdateStamp)
                .IsFixedLength();

            modelBuilder.Entity<C_AutoNumberPoolDetail>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Company>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.ProviderName)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.HandPhone)
                .IsUnicode(false);

            modelBuilder.Entity<C_Provider>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_ReportTemplate>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemStatus>()
                .Property(e => e.KEYCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemStatus>()
                .Property(e => e.STCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemStatus>()
                .Property(e => e.DRCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemStatus>()
                .Property(e => e.ENCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_SystemStatus>()
                .Property(e => e.EMCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfileCustomFind>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<C_UserProfileCustomFind>()
                .Property(e => e.FindText)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceMachine>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceMachine>()
                .Property(e => e.DutyOnTime)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceMachine>()
                .Property(e => e.DutyOffTime)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceMachine>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MaintenanceLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.NewsTitle)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.NewsSynopsis)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.NewsDetailLink)
                .IsUnicode(false);

            modelBuilder.Entity<ResourcesCenter>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<ResourcesCenter>()
                .Property(e => e.News)
                .IsUnicode(false);
        }
    }
}
