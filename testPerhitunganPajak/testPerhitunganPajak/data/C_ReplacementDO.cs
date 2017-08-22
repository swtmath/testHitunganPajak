namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ReplacementDO")]
    public partial class C_ReplacementDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_ReplacementDO()
        {
            C_ReplacementDODetail = new HashSet<C_ReplacementDODetail>();
        }

        public Guid Id { get; set; }

        public Guid? TagId { get; set; }

        public Guid? GroupDataId { get; set; }

        public int? Type { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual C_Tag C_Tag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_ReplacementDODetail> C_ReplacementDODetail { get; set; }
    }
}
