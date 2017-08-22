namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_WorkGroup")]
    public partial class C_WorkGroup
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid WorkingShiftGroupId { get; set; }

        public int? LineNumber { get; set; }

        public Guid? WorkingShiftId { get; set; }
    }
}
