namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RORequest")]
    public partial class RORequest
    {
        public Guid Id { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? RosterId { get; set; }

        public DateTime? Date { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? GroupDataId { get; set; }

        public int? Duration { get; set; }

        public int? UnitType { get; set; }

        public int? DurationType { get; set; }
    }
}
