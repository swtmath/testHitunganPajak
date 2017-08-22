namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimRequestDetail")]
    public partial class ClaimRequestDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ClaimRequestId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Payment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? DependentId { get; set; }

        public Guid? ClaimDetailId { get; set; }

        [StringLength(100)]
        public string HealthCareProvider { get; set; }

        public int? LineNumber { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileContains { get; set; }

        public virtual ClaimRequest ClaimRequest { get; set; }
    }
}
