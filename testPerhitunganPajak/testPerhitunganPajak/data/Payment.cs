namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public Guid Id { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid PaymentScheduleId { get; set; }

        public int? Status { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Period { get; set; }

        public DateTime? FixFromDate { get; set; }

        public DateTime? FixToDate { get; set; }

        [StringLength(6)]
        public string PaymentPeriod { get; set; }

        public DateTime? PaymentFixFromDate { get; set; }

        public DateTime? PaymentFixToDate { get; set; }

        public DateTime? PaymentFromDate { get; set; }

        public DateTime? PaymentToDate { get; set; }

        public int? LineNumber { get; set; }
    }
}
