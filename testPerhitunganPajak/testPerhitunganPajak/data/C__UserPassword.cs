namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__UserPassword")]
    public partial class C__UserPassword
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserId { get; set; }

        [StringLength(500)]
        public string Password { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_User C_User { get; set; }
    }
}
