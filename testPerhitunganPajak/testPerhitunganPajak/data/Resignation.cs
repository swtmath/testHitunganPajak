namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resignation")]
    public partial class Resignation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resignation()
        {
            ResignationDetails = new HashSet<ResignationDetail>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public Guid? ResignationTypeId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? Status { get; set; }

        public bool? fLeave { get; set; }

        [Column(TypeName = "money")]
        public decimal? LeaveDay { get; set; }

        [Column(TypeName = "money")]
        public decimal? Leave { get; set; }

        [Column(TypeName = "money")]
        public decimal? LeaveTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bonus { get; set; }

        [Column(TypeName = "money")]
        public decimal? OthersDeduction { get; set; }

        [Column(TypeName = "money")]
        public decimal? OthersAddition { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gratuity { get; set; }

        public bool? fClaim { get; set; }

        [Column(TypeName = "money")]
        public decimal? ClaimTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? Claim { get; set; }

        [Column(TypeName = "money")]
        public decimal? ClaimPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeverancePayMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeritPayMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeverancePayTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeverancePay { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeritPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeritPayTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? Loan { get; set; }

        public bool? fLoan { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bank { get; set; }

        public bool? fTraining { get; set; }

        [Column(TypeName = "money")]
        public decimal? Training { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cooperative { get; set; }

        [Column(TypeName = "money")]
        public decimal? TravelAdvance { get; set; }

        [Column(TypeName = "money")]
        public decimal? Endowment { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAddition { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDeduction { get; set; }

        [StringLength(100)]
        public string ELeave { get; set; }

        [StringLength(100)]
        public string ELeaveTotal { get; set; }

        [StringLength(100)]
        public string EBonus { get; set; }

        [StringLength(100)]
        public string EClaim { get; set; }

        [StringLength(100)]
        public string EClaimTotal { get; set; }

        [StringLength(100)]
        public string ESeverancePay { get; set; }

        [StringLength(100)]
        public string EMeritPay { get; set; }

        [StringLength(100)]
        public string EMeritPayTotal { get; set; }

        [StringLength(100)]
        public string ESeverancePayTotal { get; set; }

        [StringLength(100)]
        public string ETotalAddition { get; set; }

        public int? EStatus { get; set; }

        [StringLength(100)]
        public string EEndowment { get; set; }

        [StringLength(100)]
        public string ETravelAdvance { get; set; }

        [StringLength(100)]
        public string ECooperative { get; set; }

        [StringLength(100)]
        public string ETraining { get; set; }

        [StringLength(100)]
        public string EBank { get; set; }

        [StringLength(100)]
        public string ELoan { get; set; }

        [StringLength(100)]
        public string EGratuity { get; set; }

        [StringLength(100)]
        public string EOthersAddition { get; set; }

        [StringLength(100)]
        public string EOthersDeduction { get; set; }

        [StringLength(100)]
        public string ETotalDeduction { get; set; }

        public int? DailyPaymentType { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeparationPayMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeparationPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? SeparationPayTotal { get; set; }

        [StringLength(100)]
        public string ESeparationPay { get; set; }

        [StringLength(100)]
        public string ESeparationPayTotal { get; set; }

        public Guid? ResignationReasonId { get; set; }

        public int? NumberOfInstallment { get; set; }

        public virtual C_Employee C_Employee { get; set; }

        public virtual C_ResignationType C_ResignationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResignationDetail> ResignationDetails { get; set; }
    }
}
