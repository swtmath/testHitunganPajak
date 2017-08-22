namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SalaryComponentLengthOfService")]
    public partial class C_SalaryComponentLengthOfService
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryComponentId { get; set; }

        public int? Year { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(100)]
        public string EAmount { get; set; }

        public int? EStatus { get; set; }

        public virtual C_SalaryComponent C_SalaryComponent { get; set; }
    }
}
