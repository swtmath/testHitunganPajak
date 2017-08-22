namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__Roster")]
    public partial class C__Roster
    {
        [Key]
        [Column(Order = 0)]
        public Guid RosterId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        public Guid? CalendarId { get; set; }

        public DateTime? Date { get; set; }

        public Guid? TagId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid? AttendanceCodeId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? PermitLeaveCodeId { get; set; }

        public DateTime? PermitLeaveOnDate { get; set; }

        [StringLength(5)]
        public string PermitLeaveOnTime { get; set; }

        public DateTime? PermitLeaveOffDate { get; set; }

        [StringLength(5)]
        public string PermitLeaveOffTime { get; set; }

        public DateTime? SPLOnDate { get; set; }

        [StringLength(5)]
        public string SPLOnTime { get; set; }

        public DateTime? SPLOffDate { get; set; }

        [StringLength(5)]
        public string SPLOffTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLOnHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLOffHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLOffBreakHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLOnBreakHour { get; set; }

        public bool? fSPL { get; set; }

        public Guid? SPLOffBreakId { get; set; }

        public Guid? SPLOnBreakId { get; set; }

        public Guid? WorkingShiftId { get; set; }

        public Guid? ActualAttendanceCodeId { get; set; }

        public DateTime? DutyOnDate { get; set; }

        public DateTime? DutyOffDate { get; set; }

        [StringLength(5)]
        public string DutyOnTime { get; set; }

        [StringLength(5)]
        public string DutyOffTime { get; set; }

        public DateTime? BreakOutDate { get; set; }

        [StringLength(5)]
        public string BreakOutTime { get; set; }

        public DateTime? BreakInDate { get; set; }

        [StringLength(5)]
        public string BreakInTime { get; set; }

        public DateTime? WorkHourInDate { get; set; }

        [StringLength(5)]
        public string WorkHourInTime { get; set; }

        public DateTime? WorkHourOutDate { get; set; }

        [StringLength(5)]
        public string WorkHourOutTime { get; set; }

        public DateTime? ActualDutyOnDate { get; set; }

        [StringLength(5)]
        public string ActualDutyOnTime { get; set; }

        public DateTime? ActualDutyOffDate { get; set; }

        [StringLength(5)]
        public string ActualDutyOffTime { get; set; }

        public DateTime? ActualBreakOutDate { get; set; }

        public DateTime? ActualBreakInDate { get; set; }

        [StringLength(5)]
        public string ActualBreakOutTime { get; set; }

        [StringLength(5)]
        public string ActualBreakInTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? LateIn { get; set; }

        [Column(TypeName = "money")]
        public decimal? EarlyOut { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? DayOff { get; set; }

        [Column(TypeName = "money")]
        public decimal? WorkingHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLDeductionBreak { get; set; }

        public int? PermitLeaveType { get; set; }

        public Guid? PaymentId { get; set; }

        public Guid? LeaveCodeId { get; set; }

        public bool? Invalid { get; set; }

        public decimal? ActualWorkingHour { get; set; }

        [StringLength(100)]
        public string ActualDescription { get; set; }
    }
}
