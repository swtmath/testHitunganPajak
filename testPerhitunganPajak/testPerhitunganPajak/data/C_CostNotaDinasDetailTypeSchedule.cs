namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasDetailTypeSchedule")]
    public partial class C_CostNotaDinasDetailTypeSchedule
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasDetailId { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealDayOffAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealWorkingDayAmount { get; set; }

        public int? LineNumber { get; set; }
    }
}
