namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDetail")]
    public partial class LoanDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LoanId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? InstallmentPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeginningBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Interest { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainingLoan { get; set; }

        public int? LineNumber { get; set; }

        public int? Status { get; set; }

        public bool? EditFromExcel { get; set; }

        public Guid? PaymentId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Paid { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
