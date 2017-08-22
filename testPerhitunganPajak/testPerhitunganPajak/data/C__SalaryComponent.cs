namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__SalaryComponent")]
    public partial class C__SalaryComponent
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryComponentId { get; set; }

        public string EmployeeFormula { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? TaxType { get; set; }

        public Guid? ReferenceId { get; set; }
    }
}
