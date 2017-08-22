namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_OverTimeGroupTag")]
    public partial class C_OverTimeGroupTag
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OverTimeGroupId { get; set; }

        public Guid TagId { get; set; }

        public int? OverTimeStatusType { get; set; }

        public int? LineNumber { get; set; }

        public Guid? OverTimeId { get; set; }

        public int? OverTimeMinBeforeHour { get; set; }

        public int? OverTimeMinAfterHour { get; set; }

        public int? OverTimeAfterHour { get; set; }

        public int? OverTimeDeductionBreak { get; set; }

        public int? OverTimeDeductionWithLateIn { get; set; }
    }
}
