namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_PaySlipFieldDetail")]
    public partial class C_PaySlipFieldDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PaySlipFieldId { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? LineNumber { get; set; }
    }
}
