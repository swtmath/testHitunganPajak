namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserProfileFind")]
    public partial class C_UserProfileFind
    {
        public Guid Id { get; set; }

        public string ProfileName { get; set; }

        [Column(TypeName = "ntext")]
        public string Stream { get; set; }

        public string TransactionName { get; set; }

        public Guid? UserId { get; set; }

        public int? DefaultProfile { get; set; }

        public int? LineNumber { get; set; }

        public int? Priority { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
