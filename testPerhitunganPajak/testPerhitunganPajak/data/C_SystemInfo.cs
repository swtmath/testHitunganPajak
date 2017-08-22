namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SystemInfo")]
    public partial class C_SystemInfo
    {
        public Guid Id { get; set; }

        public int? MinPasswordLength { get; set; }

        public int? MaxAccountPasswordAge { get; set; }

        public int? MinValidityRetype { get; set; }

        public int? MaxLogOnFailed { get; set; }

        public DateTime? UpdateStamp { get; set; }

        public int? LeaveDayType { get; set; }

        public int? LeaveDayProportional { get; set; }

        public int? DayWorkingHour { get; set; }

        public int? WeekWorkingDay { get; set; }

        public int? EmergeLeaveDay { get; set; }

        public int? ClaimDayType { get; set; }

        public int? EmergeClaimDay { get; set; }

        public int? ClaimDayProportional { get; set; }

        public bool? LeaveAllowMinus { get; set; }

        public int? LeaveMaxMinus { get; set; }

        public bool? ClaimAllowMinus { get; set; }

        public int? DateFormat { get; set; }

        public DateTime? PayrollLastRunDate { get; set; }

        public DateTime? PayrollNextRunDate { get; set; }

        public DateTime? PayrollBackUpLastRunDate { get; set; }

        public bool? PayrollRollBack { get; set; }

        public bool? PayrollRequirePolling { get; set; }

        public int? SetupStatus { get; set; }

        public int? Status { get; set; }

        public int? MaxOverTimeDays { get; set; }

        public int? MaxOverTimeWeeks { get; set; }

        public bool? UseActiveDirectory { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinDenominator { get; set; }

        public int? AlertMinus { get; set; }

        public int? AlertPlus { get; set; }

        public bool? PaymentPeriodMonthly { get; set; }

        public int? MaxRangeDate { get; set; }

        public int? OverTimeAfterHour { get; set; }

        public int? OverTimeDeductionBreak { get; set; }

        public DateTime? AttendanceLastRunDate { get; set; }

        public DateTime? AttendanceNextRunDate { get; set; }

        public DateTime? AttendanceBackUpLastRunDate { get; set; }

        public bool? AttendanceRollBack { get; set; }

        [StringLength(50)]
        public string ActiveDirectoryDomain { get; set; }

        public DateTime? HRLastRunDate { get; set; }

        public DateTime? HRNextRunDate { get; set; }

        public DateTime? HRBackUpLastRunDate { get; set; }

        public bool? HRRollBack { get; set; }

        public int? MaxOverTimeMonth { get; set; }

        public int? PensionFAge { get; set; }

        public int? PensionMAge { get; set; }

        public bool? OverRideLeave { get; set; }

        public bool? ActualDutyComplete { get; set; }

        [StringLength(50)]
        public string SMTPServer { get; set; }

        [StringLength(50)]
        public string SMTPUserName { get; set; }

        [StringLength(50)]
        public string SMTPPassword { get; set; }

        [StringLength(50)]
        public string SMTPAdminEmail { get; set; }

        public bool? KeepMinDenominator { get; set; }

        public bool? CollapseData { get; set; }

        public bool? SMTPRandomPassword { get; set; }

        public bool? HistoryRoster { get; set; }

        [StringLength(1000)]
        public string ESlipSubject { get; set; }

        [StringLength(8000)]
        public string ESlipBody { get; set; }

        [StringLength(1000)]
        public string ESlipResetSubject { get; set; }

        [StringLength(8000)]
        public string ESlipResetBody { get; set; }

        [StringLength(1000)]
        public string ESlipInvitationSubject { get; set; }

        [StringLength(8000)]
        public string ESlipInvitationBody { get; set; }

        public int? ClaimDependentAge { get; set; }

        public bool? LeaveBecomeOvertime { get; set; }

        public bool? AutoNumberTransaction { get; set; }

        public bool? EncryptDecrypt { get; set; }

        public int? EncryptDecryptStatus { get; set; }

        public DateTime? PollingLastRunDate { get; set; }

        public DateTime? PollingNextRunDate { get; set; }

        public bool? PollingRollBackStatus { get; set; }

        public int? DiffShiftHour { get; set; }

        public int? EmployeeTransferPaymentType { get; set; }

        public int? ClaimPayment { get; set; }

        public int? SMTPPort { get; set; }

        public int? allowClaimPayment { get; set; }

        public int? SetExportDirectory { get; set; }

        public int? Thread { get; set; }

        public int? EnableSSL { get; set; }

        public int? SeveranceMeritBasedOn { get; set; }

        public int? EmployeeHistoryDay { get; set; }

        public int? TransactionHistoryDay { get; set; }

        public bool? UseBrowseDataCache { get; set; }

        public string BackupLocation { get; set; }

        public int? AutoBackup { get; set; }

        public bool? UpdateStatisticAfterProcess { get; set; }

        public int? DailyPaymentPaidOn { get; set; }

        [StringLength(1000)]
        public string NetworkProxy { get; set; }

        [StringLength(1000)]
        public string NetworkUserName { get; set; }

        [StringLength(1000)]
        public string NetworkPassword { get; set; }

        public int? AutoUpdate { get; set; }

        public int? SeveranceMeritPaidLeave { get; set; }

        public bool? SeveranceMeritLoan { get; set; }

        public int? LOSCalculateBy { get; set; }

        public bool? UseCostCenter { get; set; }

        public Guid? LockingGuid { get; set; }

        public int? StartNewDayOn { get; set; }

        public int? BeforeDutyOn { get; set; }

        public int? AfterDutyOn { get; set; }

        public int? BeforeDutyOff { get; set; }

        public int? AfterDutyOff { get; set; }

        [StringLength(100)]
        public string DayOffDutyOn { get; set; }

        [StringLength(100)]
        public string DayOffDutyOff { get; set; }

        public bool? SplitPosition { get; set; }

        public DateTime? SplitPositionDate { get; set; }

        public bool? ReplacementDO { get; set; }

        public int? ROExpiredBy { get; set; }

        public int? ROTotalDays { get; set; }

        public int? DayWorkingHourRO { get; set; }

        public bool? UseProfile { get; set; }
    }
}
