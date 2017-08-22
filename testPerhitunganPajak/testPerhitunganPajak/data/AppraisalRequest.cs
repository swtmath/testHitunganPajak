namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppraisalRequest")]
    public partial class AppraisalRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppraisalRequest()
        {
            AppraisalRequestComments = new HashSet<AppraisalRequestComment>();
            AppraisalRequestCompetencyCores = new HashSet<AppraisalRequestCompetencyCore>();
            AppraisalRequestKPIs = new HashSet<AppraisalRequestKPI>();
        }

        public Guid Id { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? SourceType { get; set; }

        public int? Year { get; set; }

        public int? Version { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? ClassId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? EndEffectiveDate { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalKPI { get; set; }

        [Column(TypeName = "money")]
        public decimal? PercentageKPI { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCompetency { get; set; }

        [Column(TypeName = "money")]
        public decimal? PercentageCompetency { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? ScoreKPI { get; set; }

        [Column(TypeName = "money")]
        public decimal? ScoreCompetency { get; set; }

        public Guid? CompetencyFinalResultId { get; set; }

        [StringLength(1000)]
        public string PerformanceImprovement { get; set; }

        [StringLength(1000)]
        public string TrainingDevelopment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppraisalRequestComment> AppraisalRequestComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppraisalRequestCompetencyCore> AppraisalRequestCompetencyCores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppraisalRequestKPI> AppraisalRequestKPIs { get; set; }
    }
}
