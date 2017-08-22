namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResourcesCenter")]
    public partial class ResourcesCenter
    {
        public Guid Id { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [StringLength(8000)]
        public string News { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        public DateTime? DateExpired { get; set; }

        public DateTime? DateAdd { get; set; }

        public int? ApplicationType { get; set; }
    }
}
