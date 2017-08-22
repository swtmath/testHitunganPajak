namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingQuestion")]
    public partial class TrainingQuestion
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public int? Visible { get; set; }

        public int? LineNumber { get; set; }
    }
}
