namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryEmployee")]
    public partial class SalaryEmployee
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? BranchId { get; set; }

        public int? EmployeeCondition { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public Guid? SalaryComponentEmployeeId { get; set; }

        public Guid? PaymentId { get; set; }

        public Guid? PaymentScheduleId { get; set; }

        public DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? TaxType { get; set; }

        public int? Type { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ReferenceId { get; set; }

        public bool? SalaryAdjustment { get; set; }

        public bool? Calculate { get; set; }

        [StringLength(100)]
        public string EAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrencyRate { get; set; }

        public int? EStatus { get; set; }

        public int? StatusEmployee { get; set; }

        public Guid? CurrencyId { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
