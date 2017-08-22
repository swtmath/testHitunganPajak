namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BaseRateAttendanceCode")]
    public partial class C_BaseRateAttendanceCode
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BaseRateId { get; set; }

        public Guid? AttendanceCodeId { get; set; }

        public int? LineNumber { get; set; }
    }
}
