namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CurrencyRate")]
    public partial class C_CurrencyRate
    {
        public Guid Id { get; set; }

        public Guid? GroupDataId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }
    }
}
