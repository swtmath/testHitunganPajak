namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SettingMandatoryField")]
    public partial class C_SettingMandatoryField
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string NamaTable { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string NamaField { get; set; }

        public int? LineNumber { get; set; }

        public bool? fMandatory { get; set; }
    }
}
