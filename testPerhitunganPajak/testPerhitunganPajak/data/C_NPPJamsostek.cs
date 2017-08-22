namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_NPPJamsostek")]
    public partial class C_NPPJamsostek
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoNumber { get; set; }
    }
}
