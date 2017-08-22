namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryAdjustmentGlobal")]
    public partial class SalaryAdjustmentGlobal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalaryAdjustmentGlobal()
        {
            SalaryAdjustmentGlobalDetails = new HashSet<SalaryAdjustmentGlobalDetail>();
        }

        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? BackPayDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public int? BStatus { get; set; }

        public int? Type { get; set; }

        public string EmployeeFormula { get; set; }

        public int? TaxType { get; set; }

        public bool? OverTimeBackPay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryAdjustmentGlobalDetail> SalaryAdjustmentGlobalDetails { get; set; }
    }
}
