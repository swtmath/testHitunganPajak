namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CustomFieldHistory")]
    public partial class C_CustomFieldHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ItemId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CustomFieldDefinitionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EffectiveDate { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }
    }
}
