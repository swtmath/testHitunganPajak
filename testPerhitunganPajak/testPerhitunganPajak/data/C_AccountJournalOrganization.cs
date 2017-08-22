namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AccountJournalOrganization")]
    public partial class C_AccountJournalOrganization
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AccountJournalId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? LineNumber { get; set; }
    }
}
