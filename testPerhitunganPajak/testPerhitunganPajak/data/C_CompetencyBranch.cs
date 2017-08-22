namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyBranch")]
    public partial class C_CompetencyBranch
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyId { get; set; }

        public Guid? BranchId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Competency C_Competency { get; set; }
    }
}
