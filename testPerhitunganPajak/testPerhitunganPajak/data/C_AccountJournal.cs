namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AccountJournal")]
    public partial class C_AccountJournal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_AccountJournal()
        {
            C_AccountJournalDetail = new HashSet<C_AccountJournalDetail>();
        }

        public Guid Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Type { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? SourceType { get; set; }

        public bool? RealParentBranch { get; set; }

        public int? FilterType { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public Guid? GroupDataId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_AccountJournalDetail> C_AccountJournalDetail { get; set; }
    }
}
