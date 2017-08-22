namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SPTMasa")]
    public partial class C_SPTMasa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_SPTMasa()
        {
            C_SPTMasaDetail = new HashSet<C_SPTMasaDetail>();
        }

        public Guid Id { get; set; }

        public int? Month { get; set; }

        public int? Year { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        [StringLength(50)]
        public string ToName { get; set; }

        [StringLength(50)]
        public string PlaceName { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string CityDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_SPTMasaDetail> C_SPTMasaDetail { get; set; }
    }
}
