namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeBank")]
    public partial class C_EmployeeBank
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Branch { get; set; }

        [StringLength(100)]
        public string AccountNo { get; set; }

        [StringLength(100)]
        public string AccountName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }
    }
}
