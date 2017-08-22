namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AccountJournalCostCenter")]
    public partial class C_AccountJournalCostCenter
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AccountJournalId { get; set; }

        public int? CostCenterType { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid JobId { get; set; }

        public Guid EmployeeId { get; set; }

        [StringLength(100)]
        public string CostCenterNumber { get; set; }

        public int? LineNumber { get; set; }
    }
}
