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
    
    public partial class C_CompetencyFinalResult
    {
        public System.Guid Id { get; set; }
        public System.Guid CompetencyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> MinimumAchievement { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual C_Competency C_Competency { get; set; }
    }
}
