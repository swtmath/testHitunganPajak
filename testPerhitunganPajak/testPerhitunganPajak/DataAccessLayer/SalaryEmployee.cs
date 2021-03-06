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
    
    public partial class SalaryEmployee
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> EmployeeId { get; set; }
        public Nullable<System.Guid> BranchId { get; set; }
        public Nullable<int> EmployeeCondition { get; set; }
        public Nullable<System.Guid> SalaryComponentId { get; set; }
        public Nullable<System.Guid> SalaryComponentEmployeeId { get; set; }
        public Nullable<System.Guid> PaymentId { get; set; }
        public Nullable<System.Guid> PaymentScheduleId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ReferenceId { get; set; }
        public Nullable<bool> SalaryAdjustment { get; set; }
        public Nullable<bool> Calculate { get; set; }
        public string EAmount { get; set; }
        public Nullable<decimal> CurrencyRate { get; set; }
        public Nullable<int> EStatus { get; set; }
        public Nullable<int> StatusEmployee { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
    
        public virtual C_Employee C_Employee { get; set; }
    }
}
