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
    
    public partial class RORequest
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> RosterId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.Guid> EmployeeId { get; set; }
        public Nullable<System.Guid> GroupDataId { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> UnitType { get; set; }
        public Nullable<int> DurationType { get; set; }
    }
}
