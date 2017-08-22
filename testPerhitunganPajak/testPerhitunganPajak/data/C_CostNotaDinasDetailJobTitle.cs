namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinasDetailJobTitle")]
    public partial class C_CostNotaDinasDetailJobTitle
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CostNotaDinasDetailId { get; set; }

        public Guid? JobTitleId { get; set; }

        public int? LineNumber { get; set; }
    }
}
