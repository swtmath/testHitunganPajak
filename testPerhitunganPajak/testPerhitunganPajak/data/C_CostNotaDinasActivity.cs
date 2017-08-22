namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasActivity")]
    public partial class C_CostNotaDinasActivity
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasId { get; set; }

        public int? TypeDestination { get; set; }

        public int? LineNumber { get; set; }
    }
}
