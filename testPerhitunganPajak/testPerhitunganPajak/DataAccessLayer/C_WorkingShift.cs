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
    
    public partial class C_WorkingShift
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string DutyOn { get; set; }
        public string DutyOff { get; set; }
        public string BreakOut { get; set; }
        public string BreakIn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> TagType { get; set; }
        public Nullable<System.Guid> GroupDataId { get; set; }
        public Nullable<int> ToleranceLateIn { get; set; }
        public Nullable<int> ToleranceEarlyOut { get; set; }
        public Nullable<System.Guid> TagId { get; set; }
        public Nullable<int> AutoSPL { get; set; }
        public string SPLOn { get; set; }
        public string SPLOff { get; set; }
        public Nullable<decimal> SPLBreakOnHour { get; set; }
        public Nullable<decimal> SPLBreakOffHour { get; set; }
        public Nullable<System.Guid> DutyBreakId { get; set; }
        public Nullable<System.Guid> SPLOnBreakId { get; set; }
        public Nullable<System.Guid> SPLOffBreakId { get; set; }
        public string Description { get; set; }
        public Nullable<int> FollowBreak { get; set; }
    }
}
