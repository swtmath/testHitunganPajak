namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_OverTimeDetail")]
    public partial class C_OverTimeDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OverTimeId { get; set; }

        [Column(TypeName = "money")]
        public decimal FromHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? Multiply { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_OverTime C_OverTime { get; set; }
    }
}
