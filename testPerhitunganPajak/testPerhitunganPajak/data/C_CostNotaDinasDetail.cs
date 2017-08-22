namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasDetail")]
    public partial class C_CostNotaDinasDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? TypeLocation { get; set; }

        public int? TypeClass { get; set; }

        [Column(TypeName = "money")]
        public decimal? AirPortTaxAmount { get; set; }

        public Guid? CurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealDayOffAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransportAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealWorkingDayAmount { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool? OverNight { get; set; }

        public int? TypeDestination { get; set; }
    }
}
