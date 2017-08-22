namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryEmployeeCustom")]
    public partial class SalaryEmployeeCustom
    {
        [Key]
        [Column(Order = 0)]
        public Guid EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PaymentId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxType { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid BranchId { get; set; }

        public int? EStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? SMEALALLOWANCE { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANBPJSKESEHATAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANJABATAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANJHT { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANJP { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANLAIN { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANRUMAH { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANTRANSPORT { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOverTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SLEMBURMIDNIGHTSALES { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUNPAIDLEAVE { get; set; }

        [Column(TypeName = "money")]
        public decimal? STHR { get; set; }

        [Column(TypeName = "money")]
        public decimal? CSTHR { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusEmployee { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sswda { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sswdp { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANLAINGROSS { get; set; }

        [Column(TypeName = "money")]
        public decimal? STUNJANGANLAINGROSSUP { get; set; }

        [Column(TypeName = "money")]
        public decimal? SDASARBPJS { get; set; }

        [Column(TypeName = "money")]
        public decimal? SBPJSMINUS { get; set; }

        [Column(TypeName = "money")]
        public decimal? SSeverance { get; set; }

        [Column(TypeName = "money")]
        public decimal? CSSeverance { get; set; }

        [Column(TypeName = "money")]
        public decimal? STunjanganBPJS { get; set; }

        [Column(TypeName = "money")]
        public decimal? SMEALALLOWANCEGROSSUP { get; set; }

        [Column(TypeName = "money")]
        public decimal? STHRGROSS { get; set; }

        [Column(TypeName = "money")]
        public decimal? CSTHRGROSS { get; set; }

        [Column(TypeName = "money")]
        public decimal? STHRGROSSUP { get; set; }

        [Column(TypeName = "money")]
        public decimal? CSTHRGROSSUP { get; set; }
    }
}
