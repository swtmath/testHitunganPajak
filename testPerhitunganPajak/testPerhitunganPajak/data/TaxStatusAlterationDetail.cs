namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxStatusAlterationDetail")]
    public partial class TaxStatusAlterationDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TaxStatusAlterationId { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? FromType { get; set; }

        public int? ToType { get; set; }

        public int? LineNumber { get; set; }
    }
}
