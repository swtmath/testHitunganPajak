namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Leave")]
    public partial class C_Leave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Leave()
        {
            C_LeaveDetail = new HashSet<C_LeaveDetail>();
            LeaveAdjustments = new HashSet<LeaveAdjustment>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? StartDateType { get; set; }

        public int? StartDateMonth { get; set; }

        public int? RunType { get; set; }

        public int? RunTypeMonth { get; set; }

        public int? ValidMonth { get; set; }

        public int? UnitType { get; set; }

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

        public int? RunTypeCalculate { get; set; }

        public int? ValidType { get; set; }

        public int? ValidUntil { get; set; }

        public int? LeaveDayType { get; set; }

        public int? EmergeLeaveDay { get; set; }

        public int? LeaveType { get; set; }

        public int? LeaveProportional { get; set; }

        public int? AmountType { get; set; }

        public string AmountFormula { get; set; }

        public int? MinimumValid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_LeaveDetail> C_LeaveDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveAdjustment> LeaveAdjustments { get; set; }
    }
}
