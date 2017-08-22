namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTransferDetail")]
    public partial class EmployeeTransferDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeTransferId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid OrganizationId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        public byte? Type { get; set; }

        public int? LineNumber { get; set; }
    }
}
