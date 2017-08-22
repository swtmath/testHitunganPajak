namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppraisalRequestComment")]
    public partial class AppraisalRequestComment
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppraisalRequestId { get; set; }

        public Guid? EmployeeId { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? LineNumber { get; set; }

        public virtual AppraisalRequest AppraisalRequest { get; set; }
    }
}
