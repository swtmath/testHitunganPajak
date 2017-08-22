namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ResignationMatrix")]
    public partial class C_ResignationMatrix
    {
        public Guid Id { get; set; }

        public int? ResignationType { get; set; }

        public int? Severance { get; set; }

        public int? Merit { get; set; }

        public int? Indemnity { get; set; }

        public int? Separation { get; set; }

        public int? IndemnityBaseRate { get; set; }
    }
}
