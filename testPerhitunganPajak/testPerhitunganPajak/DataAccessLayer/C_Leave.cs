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
    
    public partial class C_Leave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Leave()
        {
            this.C_LeaveDetail = new HashSet<C_LeaveDetail>();
            this.LeaveAdjustments = new HashSet<LeaveAdjustment>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> StartDateType { get; set; }
        public Nullable<int> StartDateMonth { get; set; }
        public Nullable<int> RunType { get; set; }
        public Nullable<int> RunTypeMonth { get; set; }
        public Nullable<int> ValidMonth { get; set; }
        public Nullable<int> UnitType { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public decimal AutoNumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> EndType { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Occurrence { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> RunTypeCalculate { get; set; }
        public Nullable<int> ValidType { get; set; }
        public Nullable<int> ValidUntil { get; set; }
        public Nullable<int> LeaveDayType { get; set; }
        public Nullable<int> EmergeLeaveDay { get; set; }
        public Nullable<int> LeaveType { get; set; }
        public Nullable<int> LeaveProportional { get; set; }
        public Nullable<int> AmountType { get; set; }
        public string AmountFormula { get; set; }
        public Nullable<int> MinimumValid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_LeaveDetail> C_LeaveDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveAdjustment> LeaveAdjustments { get; set; }
    }
}
