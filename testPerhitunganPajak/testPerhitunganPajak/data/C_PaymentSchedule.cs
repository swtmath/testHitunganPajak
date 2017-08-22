namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_PaymentSchedule")]
    public partial class C_PaymentSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_PaymentSchedule()
        {
            C_SalaryComponent = new HashSet<C_SalaryComponent>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? OnceDate { get; set; }

        public int? RunType { get; set; }

        public int? WeeklyDay1 { get; set; }

        public int? WeeklyDay2 { get; set; }

        public int? MonthlyDay1 { get; set; }

        public int? MonthlyDay2 { get; set; }

        public int? MonthlyDay21 { get; set; }

        public int? MonthlyDay3 { get; set; }

        public int? MonthlyDay31 { get; set; }

        public int? MonthlyStyle { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public int? CalculationOneFullMonth { get; set; }

        public int? WeekCutOffDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SalaryComponent> C_SalaryComponent { get; set; }
    }
}
