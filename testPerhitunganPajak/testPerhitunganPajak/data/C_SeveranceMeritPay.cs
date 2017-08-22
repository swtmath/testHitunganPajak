namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SeveranceMeritPay")]
    public partial class C_SeveranceMeritPay
    {
        public Guid Id { get; set; }

        public int? SourceType { get; set; }

        public int? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Resignation { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pension { get; set; }

        [Column(TypeName = "money")]
        public decimal? PassAway { get; set; }

        [Column(TypeName = "money")]
        public decimal? Others { get; set; }
    }
}
