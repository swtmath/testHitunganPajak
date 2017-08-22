namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SalaryComponent")]
    public partial class C_SalaryComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_SalaryComponent()
        {
            C_BaseRateDetail = new HashSet<C_BaseRateDetail>();
            C_SalaryComponentAttendanceCode = new HashSet<C_SalaryComponentAttendanceCode>();
            C_SalaryComponentDetail = new HashSet<C_SalaryComponentDetail>();
            C_SalaryComponentEmployee = new HashSet<C_SalaryComponentEmployee>();
            C_SalaryComponentLengthOfService = new HashSet<C_SalaryComponentLengthOfService>();
        }

        public Guid Id { get; set; }

        public int SourceType { get; set; }

        public Guid GroupDataId { get; set; }

        public Guid? PaymentScheduleId { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? Type { get; set; }

        public int? TaxType { get; set; }

        public int? GroupBy { get; set; }

        public int? EmployeeType { get; set; }

        public string EmployeeFormula { get; set; }

        [Column(TypeName = "money")]
        public decimal? EmployeeAmount { get; set; }

        public int? RunType { get; set; }

        public int? MonthlyDay1 { get; set; }

        public int? MonthlyDay2 { get; set; }

        public int? MonthlyDay21 { get; set; }

        public int? MonthlyDay3 { get; set; }

        public int? MonthlyDay31 { get; set; }

        public int? MonthlyStyle { get; set; }

        public int? AnnuallyDay1 { get; set; }

        public int? AnnuallyDay11 { get; set; }

        public int? AnnuallyDay2 { get; set; }

        public int? AnnuallyDay21 { get; set; }

        public int? AnnuallyDay22 { get; set; }

        public int? AnnuallyStyle { get; set; }

        public DateTime? OnceDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? EndType { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public Guid? CurrencyId { get; set; }

        [StringLength(100)]
        public string EEmployeeAmount { get; set; }

        public int? EStatus { get; set; }

        public int? DailyRunType { get; set; }

        public int? StatusEmployee { get; set; }

        public int? BStatus { get; set; }

        public bool? UsePaymentScheduleRunType { get; set; }

        public int? WeeklyDay1 { get; set; }

        [StringLength(1000)]
        public string Note { get; set; }

        public int? TransactionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_BaseRateDetail> C_BaseRateDetail { get; set; }

        public virtual C_PaymentSchedule C_PaymentSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SalaryComponentAttendanceCode> C_SalaryComponentAttendanceCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SalaryComponentDetail> C_SalaryComponentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SalaryComponentEmployee> C_SalaryComponentEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SalaryComponentLengthOfService> C_SalaryComponentLengthOfService { get; set; }
    }
}
