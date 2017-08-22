namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyJob")]
    public partial class C_CompetencyJob
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CompetencyAppraisalId { get; set; }

        public Guid? JobId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_CompetencyAppraisal C_CompetencyAppraisal { get; set; }
    }
}
