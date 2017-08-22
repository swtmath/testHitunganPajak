namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Employee")]
    public partial class C_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Employee()
        {
            C__Employee = new HashSet<C__Employee>();
            C_EmployeeCostCenter = new HashSet<C_EmployeeCostCenter>();
            C_EmployeeDependent = new HashSet<C_EmployeeDependent>();
            C_EmployeeEducation = new HashSet<C_EmployeeEducation>();
            C_EmployeeExpertise = new HashSet<C_EmployeeExpertise>();
            C_EmployeeLanguage = new HashSet<C_EmployeeLanguage>();
            C_EmployeeOrganization = new HashSet<C_EmployeeOrganization>();
            C_EmployeeReference = new HashSet<C_EmployeeReference>();
            C_EmployeeRelative = new HashSet<C_EmployeeRelative>();
            C_EmployeeTraining = new HashSet<C_EmployeeTraining>();
            LeaveRequests = new HashSet<LeaveRequest>();
            Resignations = new HashSet<Resignation>();
            SalaryEmployees = new HashSet<SalaryEmployee>();
        }

        public Guid Id { get; set; }

        [StringLength(20)]
        public string Number { get; set; }

        [StringLength(20)]
        public string Barcode { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Column(TypeName = "image")]
        public byte[] UnitDrawing { get; set; }

        [StringLength(1500)]
        public string Address { get; set; }

        [StringLength(1500)]
        public string Address1 { get; set; }

        [StringLength(1500)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string HandPhone { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        public int? Religion { get; set; }

        public int? Gender { get; set; }

        [StringLength(1500)]
        public string Hobby { get; set; }

        public int? MaritalStatus { get; set; }

        public int? EmployeeStatus { get; set; }

        public int? OverTimeStatus { get; set; }

        public Guid? OverTimeGroupId { get; set; }

        public Guid? BaseRateGroupId { get; set; }

        [StringLength(50)]
        public string PointOfHire { get; set; }

        [StringLength(50)]
        public string NPWP { get; set; }

        public DateTime? NPWPDate { get; set; }

        public bool? fNPWP { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        [StringLength(1500)]
        public string Contact1 { get; set; }

        [StringLength(1500)]
        public string Contact2 { get; set; }

        [StringLength(1500)]
        public string Contact { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string PlaceOfBirth { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? ClassId { get; set; }

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
        public string IdNumber { get; set; }

        public DateTime? IdNumberExpire { get; set; }

        [StringLength(50)]
        public string DrivingLicenseA { get; set; }

        public DateTime? DrivingLicenseAExpire { get; set; }

        [StringLength(50)]
        public string DrivingLicenseB { get; set; }

        public DateTime? DrivingLicenseBExpire { get; set; }

        [StringLength(50)]
        public string DrivingLicenseC { get; set; }

        public DateTime? DrivingLicenseCExpire { get; set; }

        [StringLength(50)]
        public string DrivingLicenseB1 { get; set; }

        public DateTime? DrivingLicenseB1Expire { get; set; }

        [StringLength(50)]
        public string DrivingLicenseB2 { get; set; }

        public DateTime? DrivingLicenseB2Expire { get; set; }

        public int? PaymentType { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ResignDate { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? EndEffectiveDate { get; set; }

        public int? BasicSalaryType { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasicSalary { get; set; }

        public Guid? BasicSalaryComponentId { get; set; }

        public int? TaxStatus { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? fJPK { get; set; }

        public DateTime? JPKDate { get; set; }

        public bool? fPensionFund { get; set; }

        [StringLength(50)]
        public string PensionFundNo { get; set; }

        public DateTime? PensionFundDate { get; set; }

        [StringLength(50)]
        public string PensionNo { get; set; }

        public bool? fPension { get; set; }

        public int? JKK { get; set; }

        [StringLength(50)]
        public string JamSosTekNo { get; set; }

        public DateTime? JamSosTekDate { get; set; }

        public bool? fJamSosTek { get; set; }

        public int? Status { get; set; }

        public int? ClaimTaxType { get; set; }

        public int? LeaveCompensationTaxType { get; set; }

        public int? SourceType { get; set; }

        public bool? FlexibleTime { get; set; }

        public int? JamSosTekTaxType { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        public int? EmployeeTaxStatus { get; set; }

        [StringLength(100)]
        public string EBasicSalary { get; set; }

        public int? EStatus { get; set; }

        [StringLength(500)]
        public string Password { get; set; }

        [Column(TypeName = "image")]
        public byte[] SignatureDrawing { get; set; }

        public bool? ResetPassword { get; set; }

        [Column(TypeName = "money")]
        public decimal? BegRSalaryNetto { get; set; }

        [Column(TypeName = "money")]
        public decimal? BegRPPH21 { get; set; }

        [StringLength(10)]
        public string PhoneExtension { get; set; }

        public Guid? RehireEmployeeId { get; set; }

        public DateTime? PensionDate { get; set; }

        public Guid? NPPJamsostekId { get; set; }

        public int? fJHT { get; set; }

        public DateTime? PayrollLastRunDate { get; set; }

        public DateTime? AttendanceLastRunDate { get; set; }

        public DateTime? HumanResourcesLastRunDate { get; set; }

        public bool? fBPJS { get; set; }

        public DateTime? BPJSDate { get; set; }

        [StringLength(50)]
        public string BPJSNo { get; set; }

        public DateTime? PaymentStartDate { get; set; }

        public int? BPJSFamily { get; set; }

        public bool? fForeign { get; set; }

        public int? TaxCountryCode { get; set; }

        [StringLength(50)]
        public string KITAS { get; set; }

        public DateTime? KITASExpire { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        public DateTime? PassportExpire { get; set; }

        public bool? fJP { get; set; }

        public DateTime? JPDate { get; set; }

        [StringLength(50)]
        public string FamilyCardNumber { get; set; }

        public DateTime? FamilyCardNumberExpire { get; set; }

        public DateTime? FirstEmploymentDate { get; set; }

        public int? HireType { get; set; }

        public string City { get; set; }

        public string City1 { get; set; }

        public string City2 { get; set; }

        public string ZipCode { get; set; }

        public string ZipCode1 { get; set; }

        public string ZipCode2 { get; set; }

        [StringLength(100)]
        public string EmailPayslip { get; set; }

        public Guid? WorkingShiftGroupId { get; set; }

        public Guid? BranchHRId { get; set; }

        public Guid? JobHRId { get; set; }

        public Guid? OrganizationHRId { get; set; }

        public Guid? ROGroupId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C__Employee> C__Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeCostCenter> C_EmployeeCostCenter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeDependent> C_EmployeeDependent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeEducation> C_EmployeeEducation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeExpertise> C_EmployeeExpertise { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeLanguage> C_EmployeeLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeOrganization> C_EmployeeOrganization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeReference> C_EmployeeReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeRelative> C_EmployeeRelative { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_EmployeeTraining> C_EmployeeTraining { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resignation> Resignations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryEmployee> SalaryEmployees { get; set; }
    }
}
