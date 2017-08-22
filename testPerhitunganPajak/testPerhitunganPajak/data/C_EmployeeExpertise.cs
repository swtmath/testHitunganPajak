namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeExpertise")]
    public partial class C_EmployeeExpertise
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
