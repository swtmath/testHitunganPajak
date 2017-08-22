namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LNDReview")]
    public partial class LNDReview
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LNDId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Result { get; set; }

        [StringLength(1000)]
        public string FollowUp { get; set; }

        [StringLength(1000)]
        public string Activity { get; set; }

        [StringLength(1000)]
        public string Realization { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public virtual LND LND { get; set; }
    }
}
