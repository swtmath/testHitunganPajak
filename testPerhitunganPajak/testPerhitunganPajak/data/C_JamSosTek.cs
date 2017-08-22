namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_JamSosTek")]
    public partial class C_JamSosTek
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? JKK1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JKK2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JKK3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JKK4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JKK5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JHTComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? JHTEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? JK { get; set; }

        [Column(TypeName = "money")]
        public decimal? JPK1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? JPK2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxJPK { get; set; }

        [Column(TypeName = "money")]
        public decimal? PensionComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? PensionEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? PensionFund { get; set; }

        public int? Year { get; set; }

        public int? Status { get; set; }

        public bool? Proportional { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxPension { get; set; }

        public bool? IncludeBackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? BPJSComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? BPJSEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxBPJS { get; set; }

        [Column(TypeName = "money")]
        public decimal? BPJSFamily { get; set; }

        public bool? UseBPJSFamily { get; set; }

        public int? MONTH { get; set; }

        public bool? BPJSProportional { get; set; }

        public bool? BPJSIncludeBackPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? JPEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? JPComp { get; set; }

        [Column(TypeName = "money")]
        public decimal? UseOtherPensionOrganizer { get; set; }

        public bool? AlwaysUseJHT { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxJP { get; set; }

        public int? DefaultJKK { get; set; }
    }
}
