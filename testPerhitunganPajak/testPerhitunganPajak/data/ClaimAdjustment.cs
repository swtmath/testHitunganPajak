namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimAdjustment")]
    public partial class ClaimAdjustment
    {
        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public Guid? ClaimCodeId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? Adjustment { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

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
