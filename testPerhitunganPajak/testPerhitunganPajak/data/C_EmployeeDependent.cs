namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EmployeeDependent")]
    public partial class C_EmployeeDependent
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EmployeeId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string PlaceOfBirth { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string HandPhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Religion { get; set; }

        public int? Gender { get; set; }

        public int? BloodType { get; set; }

        [StringLength(50)]
        public string Height { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string Ethnic { get; set; }

        [StringLength(50)]
        public string NPWP { get; set; }

        public int? Relation { get; set; }

        public bool? PassAway { get; set; }

        public int? LineNumber { get; set; }

        public bool? Claim { get; set; }

        public int? Education { get; set; }

        [StringLength(50)]
        public string Occupation { get; set; }

        [StringLength(50)]
        public string IdNumber { get; set; }

        public DateTime? IdNumberExpire { get; set; }

        public virtual C_Employee C_Employee { get; set; }
    }
}
