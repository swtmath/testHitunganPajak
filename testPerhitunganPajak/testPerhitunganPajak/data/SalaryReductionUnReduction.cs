namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryReductionUnReduction")]
    public partial class SalaryReductionUnReduction
    {
        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public DateTime? Date { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public DateTime? ReductionToDate { get; set; }

        public DateTime? ReductionFromDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReductionAmountPercentage { get; set; }

        [StringLength(1000)]
        public string ReductionDescription { get; set; }

        public DateTime? UnReductionDate { get; set; }

        [StringLength(1000)]
        public string UnReductionDescription { get; set; }

        [StringLength(1000)]
        public string UnReductionBy { get; set; }

        [StringLength(1000)]
        public string ReductionBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        public Guid? ReferenceId { get; set; }
    }
}
