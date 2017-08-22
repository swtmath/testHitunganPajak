namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeEducation")]
    public partial class C_EmployeeEducation
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Degree { get; set; }

        [StringLength(4)]
        public string StartYear { get; set; }

        [StringLength(4)]
        public string EndYear { get; set; }

        [Column(TypeName = "money")]
        public decimal? GPA { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
