namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTransaction")]
    public partial class EmployeeTransaction
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ReferenceId { get; set; }

        public int? SourceType { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? LineNumber { get; set; }

        public bool? Visible { get; set; }

        public DateTime? EffectiveTransactionDate { get; set; }
    }
}
