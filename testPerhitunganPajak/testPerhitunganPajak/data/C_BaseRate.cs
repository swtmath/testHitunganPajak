namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BaseRate")]
    public partial class C_BaseRate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_BaseRate()
        {
            C_BaseRateDetail = new HashSet<C_BaseRateDetail>();
        }

        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Type { get; set; }

        public int? BasicSalaryType { get; set; }

        public int? RunType { get; set; }

        public int? DevidedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? DevidedByAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MultipleAmount { get; set; }

        public Guid? GroupDataId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? DividerAmount { get; set; }

        public string FormulaAmount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_BaseRateDetail> C_BaseRateDetail { get; set; }
    }
}
