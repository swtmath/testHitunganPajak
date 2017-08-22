namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryAdjustmentGlobalDetail")]
    public partial class SalaryAdjustmentGlobalDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryAdjustmentGlobalId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? SalaryComponentEmployeeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewAmount { get; set; }

        public int? LineNumber { get; set; }

        public Guid? ReferenceId { get; set; }

        public Guid? BackPayReferenceId { get; set; }

        public bool? Expired { get; set; }

        [StringLength(100)]
        public string EOldAmount { get; set; }

        [StringLength(100)]
        public string ENewAmount { get; set; }

        public int? EStatus { get; set; }

        public Guid? OldClassId { get; set; }

        public Guid? NewClassId { get; set; }

        public virtual SalaryAdjustmentGlobal SalaryAdjustmentGlobal { get; set; }
    }
}
