namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaDinasDocument")]
    public partial class NotaDinasDocument
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NotaDinasId { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileContains { get; set; }

        public int? LineNumber { get; set; }

        public int? Type { get; set; }
    }
}
