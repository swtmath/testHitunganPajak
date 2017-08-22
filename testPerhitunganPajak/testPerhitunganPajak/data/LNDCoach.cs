namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LNDCoach")]
    public partial class LNDCoach
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LNDId { get; set; }

        [StringLength(1000)]
        public string Topic { get; set; }

        [StringLength(1000)]
        public string Coach { get; set; }

        public int? Month { get; set; }

        public int? LineNumber { get; set; }

        public virtual LND LND { get; set; }
    }
}
