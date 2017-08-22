namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_RoundingOvertime")]
    public partial class C_RoundingOvertime
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinuteOvertime { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinuteRounding { get; set; }
    }
}
