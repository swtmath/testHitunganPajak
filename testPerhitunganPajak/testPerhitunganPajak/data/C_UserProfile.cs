namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserProfile")]
    public partial class C_UserProfile
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? PayrollLastRunDate { get; set; }

        public DateTime? PayrollNextRunDate { get; set; }

        public DateTime? PayrollBackUpLastRunDate { get; set; }

        public bool? PayrollRollBack { get; set; }

        public DateTime? HRLastRunDate { get; set; }

        public DateTime? HRNextRunDate { get; set; }

        public DateTime? HRBackUpLastRunDate { get; set; }

        public bool? HRRollBack { get; set; }

        public DateTime? AttendanceLastRunDate { get; set; }

        public DateTime? AttendanceNextRunDate { get; set; }

        public DateTime? AttendanceBackUpLastRunDate { get; set; }

        public bool? AttendanceRollBack { get; set; }

        public bool? PollingRollBackStatus { get; set; }

        public DateTime? PollingLastRunDate { get; set; }

        public DateTime? PollingNextRunDate { get; set; }
    }
}
