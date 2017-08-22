namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActivity")]
    public partial class UserActivity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [StringLength(100)]
        public string MachineName { get; set; }

        [StringLength(15)]
        public string IpAddress { get; set; }

        [StringLength(1000)]
        public string Module { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(100)]
        public string Activity { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? SourceType { get; set; }
    }
}
