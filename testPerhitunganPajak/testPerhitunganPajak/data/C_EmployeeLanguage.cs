namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeLanguage")]
    public partial class C_EmployeeLanguage
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Spoken { get; set; }

        public int? Written { get; set; }

        public int? LineNumber { get; set; }

        public int? Hearing { get; set; }

        public int? Reading { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
