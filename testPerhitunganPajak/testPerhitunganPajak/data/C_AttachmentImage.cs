namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AttachmentImage")]
    public partial class C_AttachmentImage
    {
        public Guid Id { get; set; }

        public Guid ReferenceId { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Image { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }
    }
}
