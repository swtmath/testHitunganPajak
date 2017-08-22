namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyCoreAppraisal")]
    public partial class C_CompetencyCoreAppraisal
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyAppraisalId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CompetencyCoreId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_CompetencyAppraisal C_CompetencyAppraisal { get; set; }

        public virtual C_CompetencyCore C_CompetencyCore { get; set; }
    }
}
