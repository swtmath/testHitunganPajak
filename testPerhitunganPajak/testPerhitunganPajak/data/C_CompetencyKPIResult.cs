namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyKPIResult")]
    public partial class C_CompetencyKPIResult
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyId { get; set; }

        public int? Scale { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimumAchievement { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Competency C_Competency { get; set; }
    }
}
