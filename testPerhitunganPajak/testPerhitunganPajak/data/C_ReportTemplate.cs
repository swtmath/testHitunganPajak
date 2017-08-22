namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ReportTemplate")]
    public partial class C_ReportTemplate
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ReportId { get; set; }

        public string Memo { get; set; }

        [Column(TypeName = "ntext")]
        public string Stream { get; set; }

        public bool? Active { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
