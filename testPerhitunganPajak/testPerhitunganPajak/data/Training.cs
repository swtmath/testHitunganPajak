namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Training")]
    public partial class Training
    {
        public Guid Id { get; set; }

        public Guid? EmployeeId { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(100)]
        public string SubjectOfTraining { get; set; }

        [StringLength(100)]
        public string HRDGAManager { get; set; }

        [StringLength(100)]
        public string TrainingInstitution { get; set; }

        public DateTime? CourseStartDate { get; set; }

        public DateTime? CourseEndDate { get; set; }

        [StringLength(50)]
        public string Venue { get; set; }

        public decimal? TrainingFee { get; set; }

        [StringLength(100)]
        public string DepartmentManager { get; set; }

        [StringLength(100)]
        public string VPM { get; set; }

        public DateTime? CashDate { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(100)]
        public string FASupervisor { get; set; }

        [StringLength(20)]
        public string CurrencyName { get; set; }

        public int? CurrencyType { get; set; }

        [StringLength(100)]
        public string AccountHolder { get; set; }

        [StringLength(100)]
        public string Bank { get; set; }

        [StringLength(100)]
        public string BankBranch { get; set; }

        [StringLength(100)]
        public string AccountNo { get; set; }

        [StringLength(100)]
        public string HRDSuperintendent { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoNumber { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string MemoTo { get; set; }

        public Guid? ClassId { get; set; }
    }
}
