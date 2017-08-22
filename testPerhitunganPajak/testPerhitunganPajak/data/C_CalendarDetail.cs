namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CalendarDetail")]
    public partial class C_CalendarDetail
    {
        public Guid Id { get; set; }

        public Guid? CalendarId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? DutyOnDate { get; set; }

        public DateTime? DutyOffDate { get; set; }

        [StringLength(5)]
        public string DutyOnTime { get; set; }

        [StringLength(5)]
        public string DutyOffTime { get; set; }

        public DateTime? BreakInDate { get; set; }

        [StringLength(5)]
        public string BreakInTime { get; set; }

        public DateTime? BreakOutDate { get; set; }

        [StringLength(5)]
        public string BreakOutTime { get; set; }

        public Guid? TagId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid? WorkingShiftId { get; set; }

        public Guid? AttendanceCodeId { get; set; }

        public int? LineNumber { get; set; }

        public int? DayOff { get; set; }

        public virtual C_Calendar C_Calendar { get; set; }

        public virtual C_Tag C_Tag { get; set; }
    }
}
