namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_GroupData")]
    public partial class C_GroupData
    {
        public Guid Id { get; set; }

        public Guid? PaymentScheduleId { get; set; }

        public int? SourceType { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoNumber { get; set; }

        public int? Type { get; set; }

        public int? OverTimeStatusType { get; set; }
    }
}
