namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserProfileDetail")]
    public partial class C_UserProfileDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserProfileId { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? SourceType { get; set; }

        public int? LineNumber { get; set; }
    }
}
