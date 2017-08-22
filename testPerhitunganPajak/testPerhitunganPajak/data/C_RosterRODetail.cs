namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_RosterRODetail")]
    public partial class C_RosterRODetail
    {
        public Guid Id { get; set; }

        public Guid RosterId { get; set; }

        public Guid? RODetailId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Hour { get; set; }

        [Column(TypeName = "money")]
        public decimal? Multiply { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicRO { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public bool? BackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicSalary { get; set; }

        [StringLength(100)]
        public string EBasicSalary { get; set; }

        [StringLength(100)]
        public string EBasicRO { get; set; }

        public int? EStatus { get; set; }

        [StringLength(100)]
        public string EAmount { get; set; }
    }
}
