namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionFundDetail")]
    public partial class PensionFundDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PensionFundId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? LineNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Endowment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Term { get; set; }

        public virtual PensionFund PensionFund { get; set; }
    }
}
