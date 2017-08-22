namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CostNotaDinas")]
    public partial class C_CostNotaDinas
    {
        public Guid Id { get; set; }

        public int? Year { get; set; }

        public int? Version { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoNumber { get; set; }

        public int? Type { get; set; }
    }
}
