namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Claim")]
    public partial class C_Claim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Claim()
        {
            C_ClaimDetail = new HashSet<C_ClaimDetail>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? StartDateType { get; set; }

        public int? RunType { get; set; }

        public int? RunTypeMonth { get; set; }

        public int? ValidMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public string AmountFormula { get; set; }

        public int? AmountType { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? EndType { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Occurrence { get; set; }

        public int? Status { get; set; }

        public int? StartDateMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? AmountDependent { get; set; }

        public int? ValidType { get; set; }

        public int? ValidUntil { get; set; }

        public int? ClaimProportional { get; set; }

        public int? MinimumValid { get; set; }

        public int? RunTypeCalculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_ClaimDetail> C_ClaimDetail { get; set; }
    }
}
