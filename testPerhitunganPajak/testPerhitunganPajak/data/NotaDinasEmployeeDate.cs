namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaDinasEmployeeDate")]
    public partial class NotaDinasEmployeeDate
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NotaDinasEmployeeId { get; set; }

        public DateTime? Date { get; set; }

        public int? LineNumber { get; set; }
    }
}
