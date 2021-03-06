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
    
    public partial class ResignationDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid ResignationId { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> InstallmentPayment { get; set; }
        public Nullable<decimal> BeginningBalance { get; set; }
        public Nullable<decimal> BasicPayment { get; set; }
        public Nullable<decimal> TotalPayment { get; set; }
        public Nullable<decimal> RemainingInstallment { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> EditFromExcel { get; set; }
    
        public virtual Resignation Resignation { get; set; }
    }
}
