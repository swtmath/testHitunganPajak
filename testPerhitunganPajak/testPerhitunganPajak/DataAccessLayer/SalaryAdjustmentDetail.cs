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
    
    public partial class SalaryAdjustmentDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid SalaryAdjustmentId { get; set; }
        public Nullable<System.Guid> SalaryComponentId { get; set; }
        public Nullable<System.Guid> SalaryComponentEmployeeId { get; set; }
        public Nullable<decimal> OldAmount { get; set; }
        public Nullable<decimal> NewAmount { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public string EOldAmount { get; set; }
        public string ENewAmount { get; set; }
        public Nullable<int> EStatus { get; set; }
        public Nullable<int> Expired { get; set; }
    }
}
