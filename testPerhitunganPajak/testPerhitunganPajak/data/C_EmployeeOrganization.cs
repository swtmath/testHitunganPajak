namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeOrganization")]
    public partial class C_EmployeeOrganization
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(4)]
        public string FromYear { get; set; }

        [StringLength(4)]
        public string ToYear { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
