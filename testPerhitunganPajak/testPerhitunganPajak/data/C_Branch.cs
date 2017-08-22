namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Branch")]
    public partial class C_Branch
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public int? Level { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string NPWP { get; set; }

        [StringLength(30)]
        public string CoreBusiness { get; set; }

        [StringLength(30)]
        public string Director { get; set; }

        [StringLength(30)]
        public string NPWPTaxPerson { get; set; }

        [StringLength(50)]
        public string TaxPerson { get; set; }

        [StringLength(20)]
        public string KluCode { get; set; }

        [StringLength(50)]
        public string KPJNo { get; set; }

        public bool? UseParentNPWP { get; set; }

        public Guid? MinimumWageRegionalId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string Initial { get; set; }

        public Guid? RealParentId { get; set; }

        [StringLength(50)]
        public string ExtraData { get; set; }

        public Guid? ParentNPWPId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? TaxPersonType { get; set; }

        [Column(TypeName = "image")]
        public byte[] SignatureDrawing { get; set; }

        public int? fSignature { get; set; }

        public Guid? CompanyId { get; set; }

        [StringLength(100)]
        public string TaxPersonPosition { get; set; }

        [StringLength(10)]
        public string EFin { get; set; }

        public Guid? GroupBranch { get; set; }
    }
}
