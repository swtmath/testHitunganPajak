namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_OverTimeGroupOverTime")]
    public partial class C_OverTimeGroupOverTime
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OverTimeGroupId { get; set; }

        public Guid OverTimeId { get; set; }

        public int? LineNumber { get; set; }
    }
}
