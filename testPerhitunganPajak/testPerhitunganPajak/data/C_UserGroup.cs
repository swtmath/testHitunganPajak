namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_UserGroup")]
    public partial class C_UserGroup
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string ModuleSecurity { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
