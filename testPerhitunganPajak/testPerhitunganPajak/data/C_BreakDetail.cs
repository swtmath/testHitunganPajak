namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BreakDetail")]
    public partial class C_BreakDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BreakId { get; set; }

        [StringLength(5)]
        public string BreakIn { get; set; }

        [StringLength(5)]
        public string BreakOut { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalHour { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Break C_Break { get; set; }
    }
}
