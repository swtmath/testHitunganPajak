namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ClaimDetail")]
    public partial class C_ClaimDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ClaimId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? MinNextClaim { get; set; }

        public int? LineNumber { get; set; }

        public string FormulaBenefit { get; set; }

        public bool? PaymentEditable { get; set; }

        public virtual C_Claim C_Claim { get; set; }
    }
}
