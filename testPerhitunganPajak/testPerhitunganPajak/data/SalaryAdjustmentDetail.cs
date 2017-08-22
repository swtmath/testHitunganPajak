namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryAdjustmentDetail")]
    public partial class SalaryAdjustmentDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryAdjustmentId { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public Guid? SalaryComponentEmployeeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewAmount { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(100)]
        public string EOldAmount { get; set; }

        [StringLength(100)]
        public string ENewAmount { get; set; }

        public int? EStatus { get; set; }

        public int? Expired { get; set; }
    }
}
