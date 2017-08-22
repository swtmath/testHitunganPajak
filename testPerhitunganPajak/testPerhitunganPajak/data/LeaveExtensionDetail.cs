namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveExtensionDetail")]
    public partial class LeaveExtensionDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LeaveExtensionId { get; set; }

        public Guid? EmployeeEmergeLeaveId { get; set; }

        public Guid? EmployeeId { get; set; }

        public DateTime? ExtendedDate { get; set; }

        public int? LineNumber { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? LeaveId { get; set; }

        public Guid? ReferenceId { get; set; }

        public virtual LeaveExtension LeaveExtension { get; set; }
    }
}
