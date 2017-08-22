namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Class")]
    public partial class C_Class
    {
        public Guid Id { get; set; }

        public Guid GradeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? FromAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToAmount { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public decimal? MidAmount { get; set; }

        public virtual C_Grade C_Grade { get; set; }
    }
}
