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
    
    public partial class ClaimRequestDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid ClaimRequestId { get; set; }
        public Nullable<decimal> Payment { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> DependentId { get; set; }
        public Nullable<System.Guid> ClaimDetailId { get; set; }
        public string HealthCareProvider { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string FileName { get; set; }
        public byte[] FileContains { get; set; }
    
        public virtual ClaimRequest ClaimRequest { get; set; }
    }
}
