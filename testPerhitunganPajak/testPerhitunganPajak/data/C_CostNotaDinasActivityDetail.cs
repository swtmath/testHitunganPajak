namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasActivityDetail")]
    public partial class C_CostNotaDinasActivityDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasActivityId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Other { get; set; }

        public bool? Meal { get; set; }

        public int? LineNumber { get; set; }
    }
}
