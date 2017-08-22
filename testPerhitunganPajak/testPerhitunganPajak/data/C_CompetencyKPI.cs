namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyKPI")]
    public partial class C_CompetencyKPI
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyId { get; set; }

        [StringLength(1000)]
        public string KeyResultArea { get; set; }

        [StringLength(1000)]
        public string KPI { get; set; }

        [StringLength(1000)]
        public string TrackingSource { get; set; }

        public Guid? JobId { get; set; }

        public int? LineNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public virtual C_Competency C_Competency { get; set; }
    }
}
