namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyCoreGrade")]
    public partial class C_CompetencyCoreGrade
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyGradeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CompetencyCoreId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Standard { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_CompetencyCore C_CompetencyCore { get; set; }

        public virtual C_CompetencyGrade C_CompetencyGrade { get; set; }
    }
}
