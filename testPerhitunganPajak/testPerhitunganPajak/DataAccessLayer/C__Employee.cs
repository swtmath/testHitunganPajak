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
    
    public partial class C__Employee
    {
        public System.Guid Id { get; set; }
        public System.Guid EmployeeId { get; set; }
        public Nullable<int> EmployeeStatus { get; set; }
        public Nullable<System.Guid> BranchId { get; set; }
        public Nullable<System.Guid> JobId { get; set; }
        public Nullable<System.Guid> OrganizationId { get; set; }
        public Nullable<System.Guid> ClassId { get; set; }
        public Nullable<int> BasicSalaryType { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public Nullable<System.Guid> BasicSalaryComponentId { get; set; }
        public Nullable<int> TaxStatus { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ContractDate { get; set; }
        public Nullable<System.DateTime> EndContractDate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public Nullable<System.Guid> ResignationTypeId { get; set; }
        public Nullable<bool> SalaryAdjustment { get; set; }
        public Nullable<System.DateTime> BackPayDate { get; set; }
        public Nullable<bool> DifferenceNPWP { get; set; }
        public Nullable<bool> EmployeeTransfer { get; set; }
        public Nullable<System.Guid> EmployeeTransferId { get; set; }
        public Nullable<System.Guid> SalaryAdjustmentId { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> WorkingEffectiveDate { get; set; }
        public Nullable<System.Guid> ResignationId { get; set; }
        public string BasicSalaryComponentNumber { get; set; }
        public Nullable<bool> Calculate { get; set; }
        public string EBasicSalary { get; set; }
        public Nullable<int> EStatus { get; set; }
        public Nullable<System.DateTime> ProbationDate { get; set; }
        public Nullable<System.DateTime> EndProbationDate { get; set; }
        public Nullable<int> SalaryExpired { get; set; }
    
        public virtual C_Employee C_Employee { get; set; }
    }
}
