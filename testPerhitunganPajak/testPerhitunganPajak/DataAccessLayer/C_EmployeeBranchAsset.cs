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
    
    public partial class C_EmployeeBranchAsset
    {
        public System.Guid Id { get; set; }
        public System.Guid EmployeeId { get; set; }
        public Nullable<System.Guid> BranchAssetId { get; set; }
        public Nullable<int> LineNumber { get; set; }
    
        public virtual C_BranchAsset C_BranchAsset { get; set; }
    }
}
