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
    
    public partial class C_CompetencyCoreGrade
    {
        public System.Guid Id { get; set; }
        public System.Guid CompetencyGradeId { get; set; }
        public System.Guid CompetencyCoreId { get; set; }
        public Nullable<decimal> Standard { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual C_CompetencyCore C_CompetencyCore { get; set; }
        public virtual C_CompetencyGrade C_CompetencyGrade { get; set; }
    }
}
