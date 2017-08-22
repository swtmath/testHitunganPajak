namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__EmployeeEmergeLeave")]
    public partial class C__EmployeeEmergeLeave
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? Total { get; set; }

        public int? Planning { get; set; }

        public int? Claimed { get; set; }

        public int? UnitType { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        public Guid? LeaveId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? OriginalExpiredDate { get; set; }

        public bool? Extended { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ParentId { get; set; }

        public bool? Expired { get; set; }

        public Guid? ReferenceId { get; set; }

        public bool? Calculate { get; set; }

        public Guid? LeaveCodeId { get; set; }
    }
}
