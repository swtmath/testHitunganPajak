namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTransfer")]
    public partial class EmployeeTransfer
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? FromJobId { get; set; }

        public Guid? FromOrganizationId { get; set; }

        public Guid? FromBranchId { get; set; }

        public Guid? ToJobId { get; set; }

        public Guid? ToOrganizationId { get; set; }

        public Guid? ToBranchId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public DateTime? EndEffectiveDate { get; set; }

        public Guid? EmpTransferReasonId { get; set; }

        public Guid? FromJobHRId { get; set; }

        public Guid? FromOrganizationHRId { get; set; }

        public Guid? FromBranchHRId { get; set; }

        public Guid? ToJobHRId { get; set; }

        public Guid? ToOrganizationHRId { get; set; }

        public Guid? ToBranchHRId { get; set; }

        public int? EmployeeTransferType { get; set; }

        public DateTime? PlacementExpiredDate { get; set; }

        public Guid? EmployeeTransferParentId { get; set; }

        public virtual C_Job C_Job { get; set; }

        public virtual C_Job C_Job1 { get; set; }

        public virtual C_Organization C_Organization { get; set; }

        public virtual C_Organization C_Organization1 { get; set; }
    }
}
