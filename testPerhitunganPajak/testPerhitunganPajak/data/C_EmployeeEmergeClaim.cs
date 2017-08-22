namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeEmergeClaim")]
    public partial class C_EmployeeEmergeClaim
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public Guid? EmployeeId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? Planning { get; set; }

        [Column(TypeName = "money")]
        public decimal? Claimed { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        public Guid? ClaimId { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? OriginalExpiredDate { get; set; }

        public bool? Extended { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ParentId { get; set; }

        public bool? Expired { get; set; }

        public Guid? ReferenceId { get; set; }

        public Guid? ClaimDetailId { get; set; }

        public bool? Calculate { get; set; }

        [StringLength(100)]
        public string ETotal { get; set; }

        [StringLength(100)]
        public string EPlanning { get; set; }

        [StringLength(100)]
        public string EClaimed { get; set; }

        public int? EStatus { get; set; }
    }
}
