namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SalaryComponentAttendanceCode")]
    public partial class C_SalaryComponentAttendanceCode
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SalaryComponentId { get; set; }

        public Guid? AttendanceCodeId { get; set; }

        public virtual C_SalaryComponent C_SalaryComponent { get; set; }
    }
}
