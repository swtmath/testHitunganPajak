namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompetencyGrade")]
    public partial class C_CompetencyGrade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_CompetencyGrade()
        {
            C_CompetencyCoreGrade = new HashSet<C_CompetencyCoreGrade>();
        }

        public Guid Id { get; set; }

        public Guid CompetencyId { get; set; }

        public Guid GradeId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Competency C_Competency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreGrade> C_CompetencyCoreGrade { get; set; }
    }
}
