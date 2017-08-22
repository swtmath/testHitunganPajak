namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SalaryComponentEmployee")]
    public partial class C_SalaryComponentEmployee
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryComponentId { get; set; }

        public Guid? EmployeeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? LineNumber { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? Visible { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? ReferenceType { get; set; }

        [StringLength(100)]
        public string EAmount { get; set; }

        public int? EStatus { get; set; }

        public virtual C_SalaryComponent C_SalaryComponent { get; set; }
    }
}
