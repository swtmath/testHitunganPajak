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
    
    public partial class C_CustomField
    {
        public System.Guid Id { get; set; }
        public System.Guid ItemId { get; set; }
        public Nullable<int> SourceType { get; set; }
        public Nullable<System.Guid> CustomFieldDefinitionId { get; set; }
        public string Value { get; set; }
    
        public virtual C_CustomFieldDefinition C_CustomFieldDefinition { get; set; }
    }
}
