namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RollBackTransaction")]
    public partial class RollBackTransaction
    {
        [Key]
        public Guid EmployeeId { get; set; }
    }
}
