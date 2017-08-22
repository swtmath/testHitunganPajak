namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveCompensationDetail")]
    public partial class LeaveCompensationDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LeaveCompensationId { get; set; }

        public Guid? EmployeeEmergeLeaveId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? LineNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public Guid? ReferenceId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? LeaveId { get; set; }
    }
}
