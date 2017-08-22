namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BaseRateDetail")]
    public partial class C_BaseRateDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BaseRateId { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_BaseRate C_BaseRate { get; set; }

        public virtual C_SalaryComponent C_SalaryComponent { get; set; }
    }
}
