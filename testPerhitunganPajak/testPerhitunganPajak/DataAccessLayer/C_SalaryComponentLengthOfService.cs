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
    
    public partial class C_SalaryComponentLengthOfService
    {
        public System.Guid Id { get; set; }
        public System.Guid SalaryComponentId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public string EAmount { get; set; }
        public Nullable<int> EStatus { get; set; }
    
        public virtual C_SalaryComponent C_SalaryComponent { get; set; }
    }
}
