namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_DropDownItemDetail")]
    public partial class C_DropDownItemDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DropDownItemId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? LineNumber { get; set; }

        public virtual C_DropDownItem C_DropDownItem { get; set; }
    }
}
