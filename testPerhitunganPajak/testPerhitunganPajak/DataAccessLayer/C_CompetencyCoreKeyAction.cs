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
    
    public partial class C_CompetencyCoreKeyAction
    {
        public System.Guid Id { get; set; }
        public System.Guid CompetencyCoreId { get; set; }
        public string Description { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual C_CompetencyCore C_CompetencyCore { get; set; }
    }
}
