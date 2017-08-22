namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessQueueDetail")]
    public partial class ProcessQueueDetail
    {
        public Guid Id { get; set; }

        public Guid ProcessQueueId { get; set; }

        public DateTime? RunDate { get; set; }

        public Guid? ReferenceId { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? ResignationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual ProcessQueue ProcessQueue { get; set; }
    }
}
