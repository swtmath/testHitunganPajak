namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryAdjustment")]
    public partial class SalaryAdjustment
    {
        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? OldClassId { get; set; }

        public Guid? OldGradeId { get; set; }

        public int? OldBasicSalaryType { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldBasicSalary { get; set; }

        public Guid? OldSalaryComponentId { get; set; }

        public Guid? OldSalaryComponentEmployeeId { get; set; }

        public Guid? NewClassId { get; set; }

        public Guid? NewGradeId { get; set; }

        public int? NewBasicSalaryType { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewBasicSalary { get; set; }

        public Guid? NewSalaryComponentId { get; set; }

        public Guid? EmployeeId { get; set; }

        public DateTime? BackPayDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public Guid? ReferenceId { get; set; }

        public Guid? BackPayReferenceId { get; set; }

        [StringLength(100)]
        public string ENewBasicSalary { get; set; }

        [StringLength(100)]
        public string EOldBasicSalary { get; set; }

        public int? EStatus { get; set; }

        public bool? OverTimeBackPay { get; set; }
    }
}
