namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_PPH21")]
    public partial class C_PPH21
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? FromAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        public int? Year { get; set; }

        public int? Type { get; set; }

        public int? MONTH { get; set; }
    }
}
