namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaDinasCC")]
    public partial class NotaDinasCC
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NotaDinasId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? ClassId { get; set; }

        public int? LineNumber { get; set; }
    }
}
