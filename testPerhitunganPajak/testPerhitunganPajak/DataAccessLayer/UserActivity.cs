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
    
    public partial class UserActivity
    {
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public string MachineName { get; set; }
        public string IpAddress { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }
        public string Activity { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ReferenceId { get; set; }
        public Nullable<int> SourceType { get; set; }
    }
}
