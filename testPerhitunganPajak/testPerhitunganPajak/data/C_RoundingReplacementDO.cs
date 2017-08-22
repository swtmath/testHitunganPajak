namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_RoundingReplacementDO")]
    public partial class C_RoundingReplacementDO
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinuteReplacementDO { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinuteRounding { get; set; }
    }
}
