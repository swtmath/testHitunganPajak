namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttendanceMachine")]
    public partial class AttendanceMachine
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Barcode { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string DutyOnTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(5)]
        public string DutyOffTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Location { get; set; }

        public int? Status { get; set; }
    }
}
