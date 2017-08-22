namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_LeaveDetail")]
    public partial class C_LeaveDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LeaveId { get; set; }

        public int? FromAmount { get; set; }

        public int? ToAmount { get; set; }

        public int? Length { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Leave C_Leave { get; set; }
    }
}
