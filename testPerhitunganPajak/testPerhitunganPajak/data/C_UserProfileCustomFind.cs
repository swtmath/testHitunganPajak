namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserProfileCustomFind")]
    public partial class C_UserProfileCustomFind
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserProfileId { get; set; }

        public string Filter { get; set; }

        public string FindText { get; set; }
    }
}
