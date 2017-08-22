namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyCoreScale")]
    public partial class C_CompetencyCoreScale
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyCoreId { get; set; }

        public int? Scale { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_CompetencyCore C_CompetencyCore { get; set; }
    }
}
