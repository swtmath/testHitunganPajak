namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Tax")]
    public partial class C_Tax
    {
        public Guid Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? PTKPPribadi { get; set; }

        [Column(TypeName = "money")]
        public decimal? PTKPIstri { get; set; }

        [Column(TypeName = "money")]
        public decimal? PTKPAnak { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxBiayaJabatan { get; set; }

        [Column(TypeName = "money")]
        public decimal? BiayaJabatanPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Expatriat { get; set; }

        public int? Method { get; set; }

        public int? Type { get; set; }

        public int? FirstCalculate { get; set; }

        public int? Year { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxSalaryPem { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxDailyWage { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinMonthlyWage { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxMonthlyWage { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPH21Wage { get; set; }

        public decimal? PPH21TenagaAhli { get; set; }

        public int? TaxSeveranceAndMeritPay { get; set; }

        public int? MONTH { get; set; }

        public int? ClaimTaxType { get; set; }

        public int? LeaveTaxType { get; set; }

        public bool? UseTaxAllowanceTaxCompany { get; set; }
    }
}
