namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AutoNumber")]
    public partial class C_AutoNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Type { get; set; }

        [StringLength(10)]
        public string Prefix { get; set; }

        public long? LastKey { get; set; }

        public int? Style { get; set; }

        public int? LengthNumber { get; set; }

        public int? AutoNumber { get; set; }
    }
}
