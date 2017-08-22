namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessQueue")]
    public partial class ProcessQueue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessQueue()
        {
            ProcessQueueDetails = new HashSet<ProcessQueueDetail>();
        }

        public Guid Id { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? SourceType { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? NextRunDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? EndType { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Occurrence { get; set; }

        public Guid? EmployeeId { get; set; }

        public bool? Active { get; set; }

        public Guid? ResignationId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? StatusEmployee { get; set; }

        public DateTime? OriginalEndDate { get; set; }

        public Guid? KeyId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessQueueDetail> ProcessQueueDetails { get; set; }
    }
}
