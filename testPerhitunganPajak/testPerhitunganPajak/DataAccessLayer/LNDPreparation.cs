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
    
    public partial class LNDPreparation
    {
        public System.Guid Id { get; set; }
        public System.Guid LNDId { get; set; }
        public string Target { get; set; }
        public string Topic { get; set; }
        public string Location { get; set; }
        public Nullable<int> Month { get; set; }
        public string Description { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual LND LND { get; set; }
    }
}
