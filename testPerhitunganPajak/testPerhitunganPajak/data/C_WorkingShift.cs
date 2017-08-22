namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_WorkingShift")]
    public partial class C_WorkingShift
    {
        public Guid Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(5)]
        public string DutyOn { get; set; }

        [StringLength(5)]
        public string DutyOff { get; set; }

        [StringLength(5)]
        public string BreakOut { get; set; }

        [StringLength(5)]
        public string BreakIn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? TagType { get; set; }

        public Guid? GroupDataId { get; set; }

        public int? ToleranceLateIn { get; set; }

        public int? ToleranceEarlyOut { get; set; }

        public Guid? TagId { get; set; }

        public int? AutoSPL { get; set; }

        [StringLength(5)]
        public string SPLOn { get; set; }

        [StringLength(5)]
        public string SPLOff { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLBreakOnHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? SPLBreakOffHour { get; set; }

        public Guid? DutyBreakId { get; set; }

        public Guid? SPLOnBreakId { get; set; }

        public Guid? SPLOffBreakId { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? FollowBreak { get; set; }
    }
}
