namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeTraining")]
    public partial class C_EmployeeTraining
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(500)]
        public string Organizer { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? Certificate { get; set; }

        public int? LineNumber { get; set; }

        public DateTime? ValidDate { get; set; }

        public decimal? Duration { get; set; }

        [Column(TypeName = "money")]
        public decimal? TrainingFee { get; set; }

        public decimal? Rating { get; set; }

        public Guid? ProviderId { get; set; }

        public Guid? TrainingGroupId { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
