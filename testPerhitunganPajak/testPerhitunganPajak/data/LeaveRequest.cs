namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveRequest")]
    public partial class LeaveRequest
    {
        public Guid Id { get; set; }

        public DateTime? Date { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? ReplaceById { get; set; }

        [StringLength(1000)]
        public string Contact { get; set; }

        [StringLength(1000)]
        public string Reason { get; set; }

        public Guid? RosterId { get; set; }

        public int? Duration { get; set; }

        public int? UnitType { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
