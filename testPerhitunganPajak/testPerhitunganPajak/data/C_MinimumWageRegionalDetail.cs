namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_MinimumWageRegionalDetail")]
    public partial class C_MinimumWageRegionalDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MinimumWageRegionalId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public DateTime? EffectiveDate { get; set; }
    }
}
