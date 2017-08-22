namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserDetail")]
    public partial class C_UserDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserId { get; set; }

        public Guid? ReferenceId { get; set; }

        public int? SourceType { get; set; }

        public int? LineNumber { get; set; }
    }
}
