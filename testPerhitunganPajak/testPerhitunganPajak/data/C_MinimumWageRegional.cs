namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_MinimumWageRegional")]
    public partial class C_MinimumWageRegional
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal? Amount { get; set; }
    }
}
