namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Report")]
    public partial class C_Report
    {
        public Guid Id { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string FileName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? SourceType { get; set; }

        public int? DataSourceType { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? SubReport { get; set; }

        public Guid? ParentId { get; set; }

        public int? Type { get; set; }

        public int? ReportSaveType { get; set; }
    }
}
