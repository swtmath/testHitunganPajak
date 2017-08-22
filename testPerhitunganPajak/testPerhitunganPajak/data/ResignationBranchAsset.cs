namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResignationBranchAsset")]
    public partial class ResignationBranchAsset
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResignationId { get; set; }

        public Guid? BranchAssetId { get; set; }

        public int? LineNumber { get; set; }
    }
}
