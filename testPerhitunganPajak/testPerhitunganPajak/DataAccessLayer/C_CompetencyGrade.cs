//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testPerhitunganPajak.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_CompetencyGrade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_CompetencyGrade()
        {
            this.C_CompetencyCoreGrade = new HashSet<C_CompetencyCoreGrade>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid CompetencyId { get; set; }
        public System.Guid GradeId { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual C_Competency C_Competency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CompetencyCoreGrade> C_CompetencyCoreGrade { get; set; }
    }
}
