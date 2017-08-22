namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public Guid Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(500)]
        public string NewsTitle { get; set; }

        public DateTime? NewsDate { get; set; }

        public int? NewsIndex { get; set; }

        [StringLength(5000)]
        public string NewsSynopsis { get; set; }

        [StringLength(500)]
        public string NewsDetailLink { get; set; }

        public int? NewsType { get; set; }
    }
}
