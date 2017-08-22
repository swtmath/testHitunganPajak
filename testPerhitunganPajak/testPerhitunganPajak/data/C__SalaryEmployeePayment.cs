namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__SalaryEmployeePayment")]
    public partial class C__SalaryEmployeePayment
    {
        public Guid Id { get; set; }

        public Guid? SalaryEmployeePaymentId { get; set; }

        public Guid? PaymentId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? BranchId { get; set; }

        public int? EmployeeCondition { get; set; }

        public bool? EmployeeTransfer { get; set; }

        public bool? DifferenceNPWP { get; set; }

        public Guid? ClassId { get; set; }

        public Guid? OrganizationId { get; set; }

        public bool? fJPK { get; set; }

        public DateTime? JPKDate { get; set; }

        public bool? fPensionFund { get; set; }

        [StringLength(50)]
        public string PensionFundNo { get; set; }

        public DateTime? PensionFundDate { get; set; }

        [StringLength(50)]
        public string PensionNo { get; set; }

        public bool? fPension { get; set; }

        public int? JKK { get; set; }

        [StringLength(50)]
        public string JamSosTekNo { get; set; }

        public DateTime? JamSosTekDate { get; set; }

        public bool? fJamSosTek { get; set; }

        public int? BasicSalaryType { get; set; }

        public int? TaxStatus { get; set; }

        public int? TaxType { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBBasicSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBOverTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBJamSosTek { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBAJamSosTek { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBDJamSosTek { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBackPayBasicSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBackPayOverTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBackPayAllowanceDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? RResignationAddition { get; set; }

        [Column(TypeName = "money")]
        public decimal? RResignationDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBasicSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? ROverTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? RAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? RDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? RAllowanceOnce { get; set; }

        [Column(TypeName = "money")]
        public decimal? RDeductionOnce { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? RLeave { get; set; }

        [Column(TypeName = "money")]
        public decimal? RLoan { get; set; }

        [Column(TypeName = "money")]
        public decimal? RClaim { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJKK { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJPK { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJKM { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJHTEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJHTComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RPensionComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RPensionEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RPensionFund { get; set; }

        [Column(TypeName = "money")]
        public decimal? RPensionFundComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RPensionFundEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? BiayaJabatan { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryBruto { get; set; }

        [Column(TypeName = "money")]
        public decimal? PKP { get; set; }

        [Column(TypeName = "money")]
        public decimal? PTKP { get; set; }

        [Column(TypeName = "money")]
        public decimal? BiayaJabatanOther { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryBrutoOther { get; set; }

        [Column(TypeName = "money")]
        public decimal? PKPOther { get; set; }

        [Column(TypeName = "money")]
        public decimal? PTKPOther { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21BackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Resignation { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Emp { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Once { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21BonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Claim { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Leave { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21BackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Emp { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Once { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21BonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Claim { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Leave { get; set; }

        [Column(TypeName = "money")]
        public decimal? TunjPPH21Resignation { get; set; }

        [Column(TypeName = "money")]
        public decimal? GOnce { get; set; }

        [Column(TypeName = "money")]
        public decimal? GBonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? GClaim { get; set; }

        [Column(TypeName = "money")]
        public decimal? GLeave { get; set; }

        [Column(TypeName = "money")]
        public decimal? GSalaryNetto { get; set; }

        [Column(TypeName = "money")]
        public decimal? GReduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? GBackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? GResignation { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(6)]
        public string Period { get; set; }

        public bool? Calculate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ResignDate { get; set; }

        public int? ContractNumber { get; set; }

        public DateTime? ContractDate { get; set; }

        public DateTime? EndContractDate { get; set; }

        public int? EmployeeStatus { get; set; }

        [StringLength(6)]
        public string PaymentPeriod { get; set; }

        public bool? SalaryAdjustment { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBPension { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBAPension { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBDPension { get; set; }

        [Column(TypeName = "money")]
        public decimal? GTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21BackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Resignation { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Emp { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Once { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21BonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Claim { get; set; }

        [Column(TypeName = "money")]
        public decimal? PemPPH21Leave { get; set; }

        [Column(TypeName = "money")]
        public decimal? GBegBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? GBalance { get; set; }

        [StringLength(100)]
        public string ERBasicSalary { get; set; }

        [StringLength(100)]
        public string ERBBasicSalary { get; set; }

        [StringLength(100)]
        public string ERBonusTHR { get; set; }

        [StringLength(100)]
        public string ERBJamSosTek { get; set; }

        [StringLength(100)]
        public string ERBPension { get; set; }

        public int? EmployeeTaxStatus { get; set; }

        public int? EStatus { get; set; }

        public int? StatusEmployee { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRBasicSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryBrutoYear { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryBrutoOtherYear { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRAllowanceOnce { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRDeductionOnce { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRBonusTHR { get; set; }

        [StringLength(100)]
        public string EFRBasicSalary { get; set; }

        [StringLength(100)]
        public string EFRBonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastGTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiffGTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? BegRSalaryNetto { get; set; }

        [Column(TypeName = "money")]
        public decimal? BegRPPH21 { get; set; }

        public int? ActualWorkingDay { get; set; }

        [Column(TypeName = "money")]
        public decimal? RCBasicSalary { get; set; }

        public int? LineNumberPeriod { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21BackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Emp { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Once { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21BonusTHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Claim { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Leave { get; set; }

        [Column(TypeName = "money")]
        public decimal? CompPPH21Resignation { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRBackPayBasicSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? FRBackPayAllowanceDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? RCurrencyRate { get; set; }

        public DateTime? ProbationDate { get; set; }

        public DateTime? EndProbationDate { get; set; }

        public Guid? PaymentScheduleId { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryNettoYear { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBSalaryNettoOtherYear { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBJamSosTekPlus { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBJamSosTekMinus { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBPensionMinus { get; set; }

        [StringLength(100)]
        public string ERBOverTime { get; set; }

        [StringLength(100)]
        public string ERBAllowance { get; set; }

        [StringLength(100)]
        public string ERBDeduction { get; set; }

        [StringLength(100)]
        public string ERBAJamSosTek { get; set; }

        [StringLength(100)]
        public string ERBDJamSosTek { get; set; }

        [StringLength(100)]
        public string ERBackPayBasicSalary { get; set; }

        [StringLength(100)]
        public string ERBackPayOverTime { get; set; }

        [StringLength(100)]
        public string ERBackPayAllowanceDeduction { get; set; }

        [StringLength(100)]
        public string ERResignationAddition { get; set; }

        [StringLength(100)]
        public string ERResignationDeduction { get; set; }

        [StringLength(100)]
        public string EROverTime { get; set; }

        [StringLength(100)]
        public string ERAllowance { get; set; }

        [StringLength(100)]
        public string ERDeduction { get; set; }

        [StringLength(100)]
        public string ERAllowanceOnce { get; set; }

        [StringLength(100)]
        public string ERDeductionOnce { get; set; }

        [StringLength(100)]
        public string ERLeave { get; set; }

        [StringLength(100)]
        public string ERJKK { get; set; }

        [StringLength(100)]
        public string ERJPK { get; set; }

        [StringLength(100)]
        public string ERJKM { get; set; }

        [StringLength(100)]
        public string ERJHTEmp { get; set; }

        [StringLength(100)]
        public string ERJHTComp { get; set; }

        [StringLength(100)]
        public string ERPensionComp { get; set; }

        [StringLength(100)]
        public string ERPensionEmp { get; set; }

        [StringLength(100)]
        public string ERPensionFundComp { get; set; }

        [StringLength(100)]
        public string ERPensionFundEmp { get; set; }

        [StringLength(100)]
        public string ERBAPension { get; set; }

        [StringLength(100)]
        public string ERBDPension { get; set; }

        [StringLength(100)]
        public string EFRAllowance { get; set; }

        [StringLength(100)]
        public string EFRDeduction { get; set; }

        [StringLength(100)]
        public string EFRAllowanceOnce { get; set; }

        [StringLength(100)]
        public string EFRDeductionOnce { get; set; }

        [StringLength(100)]
        public string ERCBasicSalary { get; set; }

        [StringLength(100)]
        public string EFRBackPayBasicSalary { get; set; }

        [StringLength(100)]
        public string EFRBackPayAllowanceDeduction { get; set; }

        [StringLength(100)]
        public string ERBJamSosTekPlus { get; set; }

        [StringLength(100)]
        public string ERBJamSosTekMinus { get; set; }

        [StringLength(100)]
        public string ERBPensionMinus { get; set; }

        [StringLength(100)]
        public string EGOnce { get; set; }

        [StringLength(100)]
        public string EGBonusTHR { get; set; }

        [StringLength(100)]
        public string EGClaim { get; set; }

        [StringLength(100)]
        public string EGLeave { get; set; }

        [StringLength(100)]
        public string EGSalaryNetto { get; set; }

        [StringLength(100)]
        public string EGBackPay { get; set; }

        [StringLength(100)]
        public string EGResignation { get; set; }

        [StringLength(100)]
        public string EGTotal { get; set; }

        [StringLength(100)]
        public string ELastGTotal { get; set; }

        [StringLength(100)]
        public string ERBSalaryBrutoOther { get; set; }

        [StringLength(100)]
        public string ERBSalaryBruto { get; set; }

        [StringLength(100)]
        public string ERBSalaryNettoYear { get; set; }

        [StringLength(100)]
        public string ERBSalaryNettoOtherYear { get; set; }

        [StringLength(100)]
        public string EPKP { get; set; }

        [StringLength(100)]
        public string EPKPOther { get; set; }

        public int? fJHT { get; set; }

        public bool? fBPJS { get; set; }

        public DateTime? BPJSDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBPJSComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBPJSEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBBPJS { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBABPJS { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBDBPJS { get; set; }

        [StringLength(50)]
        public string BPJSNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? RBPJSFamily { get; set; }

        [StringLength(100)]
        public string ERBBPJS { get; set; }

        [StringLength(100)]
        public string ERBPJSComp { get; set; }

        [StringLength(100)]
        public string ERBPJSEmp { get; set; }

        [StringLength(100)]
        public string ERBABPJS { get; set; }

        [StringLength(100)]
        public string ERBDBPJS { get; set; }

        [StringLength(100)]
        public string ERBPJSFamily { get; set; }

        public bool? fJP { get; set; }

        public DateTime? JPDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJPComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? RJPEmp { get; set; }

        [StringLength(100)]
        public string ERJPComp { get; set; }

        [StringLength(100)]
        public string ERJPEmp { get; set; }

        [StringLength(100)]
        public string ERClaim { get; set; }

        [StringLength(100)]
        public string EBiayaJabatan { get; set; }

        [StringLength(100)]
        public string EBiayaJabatanOther { get; set; }

        [StringLength(100)]
        public string ERBSalaryBrutoYear { get; set; }

        [StringLength(100)]
        public string ERBSalaryBrutoOtherYear { get; set; }

        [StringLength(100)]
        public string EPPH21Total { get; set; }

        [StringLength(100)]
        public string EPPH21BackPay { get; set; }

        [StringLength(100)]
        public string EPPH21Resignation { get; set; }

        [StringLength(100)]
        public string EPPH21Emp { get; set; }

        [StringLength(100)]
        public string EPPH21Once { get; set; }

        [StringLength(100)]
        public string EPPH21BonusTHR { get; set; }

        [StringLength(100)]
        public string EPPH21Claim { get; set; }

        [StringLength(100)]
        public string EPPH21Leave { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Total { get; set; }

        [StringLength(100)]
        public string ETunjPPH21BackPay { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Emp { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Once { get; set; }

        [StringLength(100)]
        public string ETunjPPH21BonusTHR { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Claim { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Leave { get; set; }

        [StringLength(100)]
        public string ETunjPPH21Resignation { get; set; }

        [StringLength(100)]
        public string ECompPPH21Total { get; set; }

        [StringLength(100)]
        public string ECompPPH21BackPay { get; set; }

        [StringLength(100)]
        public string ECompPPH21Emp { get; set; }

        [StringLength(100)]
        public string ECompPPH21Once { get; set; }

        [StringLength(100)]
        public string ECompPPH21BonusTHR { get; set; }

        [StringLength(100)]
        public string ECompPPH21Claim { get; set; }

        [StringLength(100)]
        public string ECompPPH21Leave { get; set; }

        [StringLength(100)]
        public string ECompPPH21Resignation { get; set; }

        [StringLength(100)]
        public string EPemPPH21Total { get; set; }

        [StringLength(100)]
        public string EPemPPH21BackPay { get; set; }

        [StringLength(100)]
        public string EPemPPH21Resignation { get; set; }

        [StringLength(100)]
        public string EPemPPH21Emp { get; set; }

        [StringLength(100)]
        public string EPemPPH21Once { get; set; }

        [StringLength(100)]
        public string EPemPPH21BonusTHR { get; set; }

        [StringLength(100)]
        public string EPemPPH21Claim { get; set; }

        [StringLength(100)]
        public string EPemPPH21Leave { get; set; }

        [StringLength(100)]
        public string EGbalance { get; set; }

        [StringLength(100)]
        public string EGBegBalance { get; set; }

        [StringLength(100)]
        public string EBegRPPH21 { get; set; }

        [StringLength(100)]
        public string EBegRSalaryNetto { get; set; }

        [StringLength(100)]
        public string EGReduction { get; set; }

        [StringLength(100)]
        public string EDiffGTotal { get; set; }
    }
}
