namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyCore")]
    public partial class C_CompetencyCore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_CompetencyCore()
        {
            C_CompetencyCoreKeyAction = new HashSet<C_CompetencyCoreKeyAction>();
            C_CompetencyCoreAppraisal = new HashSet<C_CompetencyCoreAppraisal>();
            C_CompetencyCoreGrade = new HashSet<C_CompetencyCoreGrade>();
            C_CompetencyCoreScale = new HashSet<C_CompetencyCoreScale>();
        }

        public Guid Id { get; set; }

        public Guid CompetencyId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public Guid? ParentId { get; set; }

        public int? Level { get; set; }

        public virtual C_Competency C_Competency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreKeyAction> C_CompetencyCoreKeyAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreAppraisal> C_CompetencyCoreAppraisal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreGrade> C_CompetencyCoreGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreScale> C_CompetencyCoreScale { get; set; }
    }
}
