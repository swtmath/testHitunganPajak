namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BaseRateTag2")]
    public partial class C_BaseRateTag2
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BaseRateId { get; set; }

        public Guid TagId { get; set; }

        public int? LineNumber { get; set; }
    }
}
