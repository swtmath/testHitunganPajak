namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_AccountJournalDetail")]
    public partial class C_AccountJournalDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AccountJournalId { get; set; }

        public Guid? SalaryComponentId { get; set; }

        public int? LineNumber { get; set; }

        public int? Type { get; set; }

        [StringLength(50)]
        public string SalaryComponentName { get; set; }

        [StringLength(50)]
        public string SalaryComponentDescription { get; set; }

        public int? PlusMinus { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public virtual C_AccountJournal C_AccountJournal { get; set; }
    }
}
