namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppraisalRequestCompetencyCore")]
    public partial class AppraisalRequestCompetencyCore
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppraisalRequestId { get; set; }

        public Guid? CompetencyCoreId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        [Column(TypeName = "money")]
        public decimal? StandardScale { get; set; }

        [Column(TypeName = "money")]
        public decimal? Scale { get; set; }

        [Column(TypeName = "money")]
        public decimal? Score { get; set; }

        [StringLength(1000)]
        public string Result { get; set; }

        public int? LineNumber { get; set; }

        public virtual AppraisalRequest AppraisalRequest { get; set; }
    }
}
