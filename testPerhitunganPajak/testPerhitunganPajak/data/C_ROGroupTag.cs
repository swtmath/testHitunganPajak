namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ROGroupTag")]
    public partial class C_ROGroupTag
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ROGroupId { get; set; }

        public Guid TagId { get; set; }

        public int? ROStatusType { get; set; }

        public int? LineNumber { get; set; }

        public Guid? ROId { get; set; }
    }
}
