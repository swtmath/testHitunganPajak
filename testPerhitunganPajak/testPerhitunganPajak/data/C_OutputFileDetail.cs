namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_OutputFileDetail")]
    public partial class C_OutputFileDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OutputFileId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }

        [StringLength(1)]
        public string PaddingChar { get; set; }

        public int? Align { get; set; }

        public int? Length { get; set; }

        public int? LineNumber { get; set; }

        public int? Type { get; set; }

        public int? FieldType { get; set; }

        public int? Line { get; set; }

        public virtual C_OutputFile C_OutputFile { get; set; }
    }
}
