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
    
    public partial class Resignation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resignation()
        {
            this.ResignationDetails = new HashSet<ResignationDetail>();
        }
    
        public System.Guid Id { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> EmployeeId { get; set; }
        public Nullable<System.Guid> BranchId { get; set; }
        public Nullable<System.Guid> JobId { get; set; }
        public Nullable<System.Guid> OrganizationId { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public decimal AutoNumber { get; set; }
        public Nullable<System.Guid> ResignationTypeId { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> fLeave { get; set; }
        public Nullable<decimal> LeaveDay { get; set; }
        public Nullable<decimal> Leave { get; set; }
        public Nullable<decimal> LeaveTotal { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        public Nullable<decimal> OthersDeduction { get; set; }
        public Nullable<decimal> OthersAddition { get; set; }
        public Nullable<decimal> Gratuity { get; set; }
        public Nullable<bool> fClaim { get; set; }
        public Nullable<decimal> ClaimTotal { get; set; }
        public Nullable<decimal> Claim { get; set; }
        public Nullable<decimal> ClaimPercentage { get; set; }
        public Nullable<decimal> SeverancePayMonth { get; set; }
        public Nullable<decimal> MeritPayMonth { get; set; }
        public Nullable<decimal> SeverancePayTotal { get; set; }
        public Nullable<decimal> SeverancePay { get; set; }
        public Nullable<decimal> MeritPay { get; set; }
        public Nullable<decimal> MeritPayTotal { get; set; }
        public Nullable<decimal> Loan { get; set; }
        public Nullable<bool> fLoan { get; set; }
        public Nullable<decimal> Bank { get; set; }
        public Nullable<bool> fTraining { get; set; }
        public Nullable<decimal> Training { get; set; }
        public Nullable<decimal> Cooperative { get; set; }
        public Nullable<decimal> TravelAdvance { get; set; }
        public Nullable<decimal> Endowment { get; set; }
        public Nullable<decimal> TotalAddition { get; set; }
        public Nullable<decimal> TotalDeduction { get; set; }
        public string ELeave { get; set; }
        public string ELeaveTotal { get; set; }
        public string EBonus { get; set; }
        public string EClaim { get; set; }
        public string EClaimTotal { get; set; }
        public string ESeverancePay { get; set; }
        public string EMeritPay { get; set; }
        public string EMeritPayTotal { get; set; }
        public string ESeverancePayTotal { get; set; }
        public string ETotalAddition { get; set; }
        public Nullable<int> EStatus { get; set; }
        public string EEndowment { get; set; }
        public string ETravelAdvance { get; set; }
        public string ECooperative { get; set; }
        public string ETraining { get; set; }
        public string EBank { get; set; }
        public string ELoan { get; set; }
        public string EGratuity { get; set; }
        public string EOthersAddition { get; set; }
        public string EOthersDeduction { get; set; }
        public string ETotalDeduction { get; set; }
        public Nullable<int> DailyPaymentType { get; set; }
        public Nullable<decimal> SeparationPayMonth { get; set; }
        public Nullable<decimal> SeparationPay { get; set; }
        public Nullable<decimal> SeparationPayTotal { get; set; }
        public string ESeparationPay { get; set; }
        public string ESeparationPayTotal { get; set; }
        public Nullable<System.Guid> ResignationReasonId { get; set; }
        public Nullable<int> NumberOfInstallment { get; set; }
    
        public virtual C_Employee C_Employee { get; set; }
        public virtual C_ResignationType C_ResignationType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResignationDetail> ResignationDetails { get; set; }
    }
}
