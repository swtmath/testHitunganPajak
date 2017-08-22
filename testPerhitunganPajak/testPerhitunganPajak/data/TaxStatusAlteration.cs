namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxStatusAlteration")]
    public partial class TaxStatusAlteration
    {
        public Guid Id { get; set; }

        public int? Year { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? EndEffectiveDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }
    }
}
