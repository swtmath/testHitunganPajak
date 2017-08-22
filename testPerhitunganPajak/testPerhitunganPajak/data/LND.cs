namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LND")]
    public partial class LND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LND()
        {
            LNDActionPlans = new HashSet<LNDActionPlan>();
            LNDAspectActions = new HashSet<LNDAspectAction>();
            LNDAspectTopics = new HashSet<LNDAspectTopic>();
            LNDCoaches = new HashSet<LNDCoach>();
            LNDLastTopics = new HashSet<LNDLastTopic>();
            LNDObjectives = new HashSet<LNDObjective>();
            LNDPreparations = new HashSet<LNDPreparation>();
            LNDReviews = new HashSet<LNDReview>();
        }

        public Guid Id { get; set; }

        public Guid? LNDPlanningDetailId { get; set; }

        public Guid? ReferenceId { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Year { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? ClassId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? Type { get; set; }

        [StringLength(500)]
        public string TypeDescription { get; set; }

        public int? TypeLocation { get; set; }

        public int? Yos { get; set; }

        public int? YosJob { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        [StringLength(1000)]
        public string Topic { get; set; }

        [StringLength(1000)]
        public string TopicPlan { get; set; }

        [Column(TypeName = "money")]
        public decimal? Expense { get; set; }

        [StringLength(500)]
        public string ProviderName { get; set; }

        [StringLength(500)]
        public string ProviderAddress { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TotalWork { get; set; }

        [StringLength(500)]
        public string Location { get; set; }

        [StringLength(1000)]
        public string Summary { get; set; }

        [StringLength(1000)]
        public string Reason { get; set; }

        [StringLength(1000)]
        public string WorkGoals { get; set; }

        [StringLength(1000)]
        public string ActualCondition { get; set; }

        [StringLength(1000)]
        public string DevelopmentGoals { get; set; }

        [StringLength(1000)]
        public string Skill { get; set; }

        public int? TypeMethod { get; set; }

        public int? Month { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        [StringLength(1000)]
        public string Problem { get; set; }

        public int? SourceType { get; set; }

        public bool? Evaluation { get; set; }

        [StringLength(1000)]
        public string EvaluationAction { get; set; }

        public int? EvaluationStatus { get; set; }

        [StringLength(1000)]
        public string EvaluationResult { get; set; }

        public Guid? CurrencyId { get; set; }

        [StringLength(1000)]
        public string TypeMethodDescription { get; set; }

        public int? Version { get; set; }

        public bool? Certificate { get; set; }

        [StringLength(100)]
        public string TypeMethodNotes { get; set; }

        [Column(TypeName = "money")]
        public decimal? LNDTopicCostAmount { get; set; }

        public Guid? LNDTopicId { get; set; }

        public Guid? PlanCurrencyId { get; set; }

        public int? RealizationMonth { get; set; }

        public bool? Pending { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDActionPlan> LNDActionPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDAspectAction> LNDAspectActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDAspectTopic> LNDAspectTopics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDCoach> LNDCoaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDLastTopic> LNDLastTopics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDObjective> LNDObjectives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDPreparation> LNDPreparations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LNDReview> LNDReviews { get; set; }
    }
}
