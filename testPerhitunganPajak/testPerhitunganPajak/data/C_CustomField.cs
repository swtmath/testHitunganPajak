namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CustomField")]
    public partial class C_CustomField
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ItemId { get; set; }

        public int? SourceType { get; set; }

        public Guid? CustomFieldDefinitionId { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }

        public virtual C_CustomFieldDefinition C_CustomFieldDefinition { get; set; }
    }
}
