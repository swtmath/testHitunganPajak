namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Competency")]
    public partial class C_Competency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Competency()
        {
            C_CompetencyAppraisal = new HashSet<C_CompetencyAppraisal>();
            C_CompetencyBranch = new HashSet<C_CompetencyBranch>();
            C_CompetencyCore = new HashSet<C_CompetencyCore>();
            C_CompetencyFinalResult = new HashSet<C_CompetencyFinalResult>();
            C_CompetencyGrade = new HashSet<C_CompetencyGrade>();
            C_CompetencyJobResult = new HashSet<C_CompetencyJobResult>();
            C_CompetencyKPI = new HashSet<C_CompetencyKPI>();
            C_CompetencyKPIResult = new HashSet<C_CompetencyKPIResult>();
        }

        public Guid Id { get; set; }

        public int? Year { get; set; }

        public int? MinScale { get; set; }

        public int? MaxScale { get; set; }

        public int? Version { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyAppraisal> C_CompetencyAppraisal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyBranch> C_CompetencyBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCore> C_CompetencyCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyFinalResult> C_CompetencyFinalResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyGrade> C_CompetencyGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyJobResult> C_CompetencyJobResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyKPI> C_CompetencyKPI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyKPIResult> C_CompetencyKPIResult { get; set; }
    }
}
