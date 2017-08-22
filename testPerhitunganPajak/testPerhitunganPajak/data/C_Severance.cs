namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Severance")]
    public partial class C_Severance
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? FromAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        public int? Year { get; set; }

        public int? MONTH { get; set; }
    }
}
