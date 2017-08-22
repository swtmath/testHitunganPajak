namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Provider")]
    public partial class C_Provider
    {
        public Guid Id { get; set; }

        [StringLength(5000)]
        public string ProviderName { get; set; }

        [StringLength(5000)]
        public string Category { get; set; }

        [StringLength(5000)]
        public string WebSite { get; set; }

        [StringLength(5000)]
        public string ContactPerson { get; set; }

        [StringLength(5000)]
        public string Phone { get; set; }

        [StringLength(5000)]
        public string HandPhone { get; set; }

        [StringLength(5000)]
        public string Email { get; set; }
    }
}
