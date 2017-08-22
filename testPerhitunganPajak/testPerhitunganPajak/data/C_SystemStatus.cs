namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SystemStatus")]
    public partial class C_SystemStatus
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid KeyId { get; set; }

        public DateTime? Date { get; set; }

        public int? Duration { get; set; }

        public int? Employee { get; set; }

        [StringLength(500)]
        public string KEYCode { get; set; }

        [StringLength(500)]
        public string STCode { get; set; }

        [StringLength(500)]
        public string DRCode { get; set; }

        [StringLength(500)]
        public string ENCode { get; set; }

        [StringLength(500)]
        public string EMCode { get; set; }
    }
}
