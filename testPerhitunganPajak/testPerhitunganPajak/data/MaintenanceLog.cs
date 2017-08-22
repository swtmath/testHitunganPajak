namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceLog")]
    public partial class MaintenanceLog
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RunType { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime EffectiveDate { get; set; }

        public string Description { get; set; }
    }
}
