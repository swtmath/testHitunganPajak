namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OvertimeRequest")]
    public partial class OvertimeRequest
    {
        public Guid Id { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? RosterId { get; set; }

        public Guid? GroupDataId { get; set; }
    }
}
