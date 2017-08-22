namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasMatrixDetail")]
    public partial class C_CostNotaDinasMatrixDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasMatrixId { get; set; }

        public int? Type { get; set; }

        public bool? Meal { get; set; }

        public bool? Day { get; set; }

        public bool? Transport { get; set; }

        public bool? AirPortTax { get; set; }

        public int? LineNumber { get; set; }

        public bool? CheckExistingCost { get; set; }
    }
}
