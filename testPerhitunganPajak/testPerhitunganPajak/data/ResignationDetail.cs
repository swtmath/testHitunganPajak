namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResignationDetail")]
    public partial class ResignationDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResignationId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? InstallmentPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeginningBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainingInstallment { get; set; }

        public int? LineNumber { get; set; }

        public int? Status { get; set; }

        public bool? EditFromExcel { get; set; }

        public virtual Resignation Resignation { get; set; }
    }
}
