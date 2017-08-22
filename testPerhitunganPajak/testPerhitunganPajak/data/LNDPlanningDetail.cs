namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LNDPlanningDetail")]
    public partial class LNDPlanningDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LNDPlanningId { get; set; }

        [StringLength(1000)]
        public string WorkGoals { get; set; }

        [StringLength(1000)]
        public string ActualCondition { get; set; }

        [StringLength(1000)]
        public string DevelopmentGoals { get; set; }

        [StringLength(1000)]
        public string Skill { get; set; }

        public int? TypeMethod { get; set; }

        [StringLength(1000)]
        public string Topic { get; set; }

        public int? Month { get; set; }

        public int? LineNumber { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string TypeMethodDescription { get; set; }

        public Guid? LNDTopicId { get; set; }

        [Column(TypeName = "money")]
        public decimal? LNDTopicCostAmount { get; set; }

        public Guid? CurrencyId { get; set; }

        public virtual LNDPlanning LNDPlanning { get; set; }
    }
}
