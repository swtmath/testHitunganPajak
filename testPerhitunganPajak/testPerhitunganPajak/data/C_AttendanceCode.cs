namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AttendanceCode")]
    public partial class C_AttendanceCode
    {
        public Guid Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Type { get; set; }

        public bool? IncludeDayOff { get; set; }

        public int? Length { get; set; }

        public int? DurationType { get; set; }

        public int? AllowMinusType { get; set; }

        public decimal? MaxMinus { get; set; }

        public int? LeaveGender { get; set; }
    }
}
