namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CustomFieldData")]
    public partial class C_CustomFieldData
    {
        [Key]
        public Guid ItemId { get; set; }
    }
}
