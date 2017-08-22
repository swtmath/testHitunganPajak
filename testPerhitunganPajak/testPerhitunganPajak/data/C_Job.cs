namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Job")]
    public partial class C_Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Job()
        {
            EmployeeTransfers = new HashSet<EmployeeTransfer>();
            EmployeeTransfers1 = new HashSet<EmployeeTransfer>();
        }

        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public Guid? JobTitleId { get; set; }

        public Guid? BranchId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Level { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(20)]
        public string Initial { get; set; }

        [StringLength(100)]
        public string CostCenterNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTransfer> EmployeeTransfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTransfer> EmployeeTransfers1 { get; set; }
    }
}
