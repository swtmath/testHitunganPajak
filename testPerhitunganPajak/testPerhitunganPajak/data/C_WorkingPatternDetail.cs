namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_WorkingPatternDetail")]
    public partial class C_WorkingPatternDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid WorkingPatternId { get; set; }

        public int? Day { get; set; }

        public Guid? WorkingShiftId { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_WorkingPattern C_WorkingPattern { get; set; }
    }
}
