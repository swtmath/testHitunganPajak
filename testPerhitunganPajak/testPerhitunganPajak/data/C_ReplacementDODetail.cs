namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ReplacementDODetail")]
    public partial class C_ReplacementDODetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ReplacementDOId { get; set; }

        [Column(TypeName = "money")]
        public decimal FromHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? Multiply { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_ReplacementDO C_ReplacementDO { get; set; }
    }
}
