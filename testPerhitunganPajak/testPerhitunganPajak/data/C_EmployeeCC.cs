namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeCC")]
    public partial class C_EmployeeCC
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        public Guid BranchId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid OrganizationId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        public int? LineNumber { get; set; }
    }
}
