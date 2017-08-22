namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LNDPreparation")]
    public partial class LNDPreparation
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LNDId { get; set; }

        [StringLength(1000)]
        public string Target { get; set; }

        [StringLength(1000)]
        public string Topic { get; set; }

        [StringLength(500)]
        public string Location { get; set; }

        public int? Month { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public virtual LND LND { get; set; }
    }
}
