namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BaseRateGroupType")]
    public partial class C_BaseRateGroupType
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BaseRateGroupId { get; set; }

        public int? Type { get; set; }

        public int? LineNumber { get; set; }

        public Guid? BaseRateId { get; set; }
    }
}
