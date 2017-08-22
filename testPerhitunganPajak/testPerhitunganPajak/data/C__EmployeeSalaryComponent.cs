namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__EmployeeSalaryComponent")]
    public partial class C__EmployeeSalaryComponent
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? Type { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public bool? Calculate { get; set; }

        [StringLength(100)]
        public string EAmount { get; set; }

        public int? EStatus { get; set; }
    }
}
