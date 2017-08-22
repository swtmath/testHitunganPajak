namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeBranchAsset")]
    public partial class C_EmployeeBranchAsset
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        public Guid? BranchAssetId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_BranchAsset C_BranchAsset { get; set; }
    }
}
