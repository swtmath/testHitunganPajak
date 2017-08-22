namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppraisalRequestKPI")]
    public partial class AppraisalRequestKPI
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppraisalRequestId { get; set; }

        [StringLength(1000)]
        public string KeyResultArea { get; set; }

        [StringLength(1000)]
        public string KPI { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        [Column(TypeName = "money")]
        public decimal? Scale { get; set; }

        [Column(TypeName = "money")]
        public decimal? Score { get; set; }

        [StringLength(1000)]
        public string TrackingSource { get; set; }

        [StringLength(1000)]
        public string MidYear { get; set; }

        [StringLength(1000)]
        public string Result { get; set; }

        public int? LineNumber { get; set; }

        public virtual AppraisalRequest AppraisalRequest { get; set; }
    }
}
