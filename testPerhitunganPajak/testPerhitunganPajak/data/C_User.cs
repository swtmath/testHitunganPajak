namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_User")]
    public partial class C_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_User()
        {
            C__UserPassword = new HashSet<C__UserPassword>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(500)]
        public string Password { get; set; }

        [Column(TypeName = "ntext")]
        public string ModuleSecurity { get; set; }

        public Guid? UserGroupId { get; set; }

        public bool? ActiveLogin { get; set; }

        public DateTime? LastLogin { get; set; }

        [StringLength(100)]
        public string MachineName { get; set; }

        [StringLength(15)]
        public string IpAddress { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? LastChangePasswordDate { get; set; }

        public DateTime? UpdateStamp { get; set; }

        public bool? Admin { get; set; }

        public bool? IsBlocking { get; set; }

        public int? BlockingCounter { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? JobTitleId { get; set; }

        public Guid? OrganizationId { get; set; }

        public DateTime? LastAccessDate { get; set; }

        public Guid? userProfileId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C__UserPassword> C__UserPassword { get; set; }
    }
}
