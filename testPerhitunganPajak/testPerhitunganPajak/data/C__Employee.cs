namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__Employee")]
    public partial class C__Employee
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public int? EmployeeStatus { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? ClassId { get; set; }

        public int? BasicSalaryType { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicSalary { get; set; }

        public Guid? BasicSalaryComponentId { get; set; }

        public int? TaxStatus { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ContractDate { get; set; }

        public DateTime? EndContractDate { get; set; }

        public int? Status { get; set; }

        public DateTime? ResignDate { get; set; }

        public Guid? ResignationTypeId { get; set; }

        public bool? SalaryAdjustment { get; set; }

        public DateTime? BackPayDate { get; set; }

        public bool? DifferenceNPWP { get; set; }

        public bool? EmployeeTransfer { get; set; }

        public Guid? EmployeeTransferId { get; set; }

        public Guid? SalaryAdjustmentId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? WorkingEffectiveDate { get; set; }

        public Guid? ResignationId { get; set; }

        [StringLength(20)]
        public string BasicSalaryComponentNumber { get; set; }

        public bool? Calculate { get; set; }

        [StringLength(100)]
        public string EBasicSalary { get; set; }

        public int? EStatus { get; set; }

        public DateTime? ProbationDate { get; set; }

        public DateTime? EndProbationDate { get; set; }

        public int? SalaryExpired { get; set; }

        public Guid? BranchHRId { get; set; }

        public Guid? JobHRId { get; set; }

        public Guid? OrganizationHRId { get; set; }

        public bool? fJamSosTek { get; set; }

        [StringLength(50)]
        public string JamSosTekNo { get; set; }

        public DateTime? JamsostekDate { get; set; }

        public Guid? NPPJamsostekId { get; set; }

        public int? JKK { get; set; }

        public DateTime? JPDate { get; set; }

        public bool? fJP { get; set; }

        [StringLength(50)]
        public string BPJSNo { get; set; }

        public DateTime? BPJSDate { get; set; }

        public bool? fBPJS { get; set; }

        public int? BPJSFamily { get; set; }

        public bool? fPension { get; set; }

        [StringLength(50)]
        public string PensionNo { get; set; }

        public DateTime? PensionDate { get; set; }

        public bool? fJHT { get; set; }

        public bool? fJPK { get; set; }

        public DateTime? fJPKDate { get; set; }

        public bool? fPensionFund { get; set; }

        [StringLength(50)]
        public string PensionFundNo { get; set; }

        public DateTime? PensionFundDate { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
