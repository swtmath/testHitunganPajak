namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BlackListIdNumber")]
    public partial class C_BlackListIdNumber
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
