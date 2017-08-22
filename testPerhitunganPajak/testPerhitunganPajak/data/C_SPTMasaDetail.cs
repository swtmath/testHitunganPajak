namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SPTMasaDetail")]
    public partial class C_SPTMasaDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SPTMasaId { get; set; }

        public int? Type { get; set; }

        public int? TotalEmployee { get; set; }

        public decimal? SalaryBruto { get; set; }

        public decimal? PPH21 { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_SPTMasa C_SPTMasa { get; set; }
    }
}
