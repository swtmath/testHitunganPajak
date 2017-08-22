namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_NomorReport1721A1")]
    public partial class C_NomorReport1721A1
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Tahun { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid EmployeeId { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(200)]
        public string NomorReport { get; set; }
    }
}
