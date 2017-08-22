namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Holiday")]
    public partial class C_Holiday
    {
        public Guid Id { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public Guid? TagId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ALReplace { get; set; }

        public virtual C_Tag C_Tag { get; set; }
    }
}
