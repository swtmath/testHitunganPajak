namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LNDPlanning")]
    public partial class LNDPlanning
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LNDPlanning()
        {
            LNDPlanningDetails = new HashSet<LNDPlanningDetail>();
        }

        public Guid Id { get; set; }

        public Guid? ReferenceId { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Year { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public Guid? ClassId { get; set; }

        public Guid? BranchId { get; set; }

        public int? Version { get; set; }

        public bool? Revised { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDPlanningDetail> LNDPlanningDetails { get; set; }
    }
}
