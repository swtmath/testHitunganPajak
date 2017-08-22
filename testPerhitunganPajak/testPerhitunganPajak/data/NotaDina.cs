namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotaDina
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public Guid? FromEmployeeId { get; set; }

        public Guid? FromBranchId { get; set; }

        public Guid? FromOrganizationId { get; set; }

        public Guid? FromJobId { get; set; }

        public Guid? FromClassId { get; set; }

        public Guid? ToEmployeeId { get; set; }

        public Guid? ToBranchId { get; set; }

        public Guid? ToOrganizationId { get; set; }

        public Guid? ToJobId { get; set; }

        public Guid? ToClassId { get; set; }

        [StringLength(50)]
        public string BudgetNumber { get; set; }

        [StringLength(50)]
        public string TaskNumber { get; set; }

        [StringLength(100)]
        public string Activity { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(8000)]
        public string Content { get; set; }

        public int? Type { get; set; }

        public int? TypeDirector { get; set; }

        public int? TypeClass { get; set; }

        public int? TypeOverNight { get; set; }

        public int? TypeLocation { get; set; }

        [StringLength(100)]
        public string TypeLocationDescription { get; set; }

        public int? TypeSchedule { get; set; }

        public Guid? CostNotaDinasDetailId { get; set; }

        public Guid? CostNotaDinasActivityDetailId { get; set; }

        [StringLength(100)]
        public string CostNotaDinasActivityDetailDescription { get; set; }

        public int? DepartTypeTransport { get; set; }

        public int? ArriveTypeTransport { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealAmount { get; set; }

        public int? MealFundType { get; set; }

        [StringLength(100)]
        public string MealFundDescripton { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FDayAmount { get; set; }

        public Guid? DayCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayCurrencyRate { get; set; }

        public int? DayFundType { get; set; }

        [StringLength(100)]
        public string DayFundDescription { get; set; }

        public Guid? DayPayCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayPayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FDayPayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayPayCurrencyRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayRemainingAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FDayRemainingAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransportAmount { get; set; }

        public int? TransportFundType { get; set; }

        [StringLength(100)]
        public string TransportFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? AirPortTaxAmount { get; set; }

        public int? AirPortTaxFundType { get; set; }

        [StringLength(100)]
        public string AirPortTaxFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FOtherAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherCurrencyRate { get; set; }

        public Guid? OtherCurrencyId { get; set; }

        public int? OtherFundType { get; set; }

        [StringLength(100)]
        public string OtherFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TicketAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FTicketAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TicketCurrencyRate { get; set; }

        public Guid? TicketCurrencyId { get; set; }

        public int? TicketFundType { get; set; }

        [StringLength(100)]
        public string TicketFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FHotelAmount { get; set; }

        public Guid? HotelCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelCurrencyRate { get; set; }

        public int? HotelFundType { get; set; }

        [StringLength(100)]
        public string HotelFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? PassportAmount { get; set; }

        public int? PassportFundType { get; set; }

        [StringLength(100)]
        public string PassportFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? VisaAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FVisaAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? VisaCurrencyRate { get; set; }

        public Guid? VisaCurrencyId { get; set; }

        public int? VisaFundType { get; set; }

        [StringLength(100)]
        public string VisaFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelTransitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FHotelTransitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelTransitCurrencyRate { get; set; }

        public Guid? HotelTransitCurrencyId { get; set; }

        public int? HotelTransitFundType { get; set; }

        [StringLength(100)]
        public string HotelTransitFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsuranceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FInsuranceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsuranceCurrencyRate { get; set; }

        public Guid? InsuranceCurrencyId { get; set; }

        public int? InsuranceFundType { get; set; }

        [StringLength(100)]
        public string InsuranceFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal AutoNumber { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string ActivityDate { get; set; }

        public int? TypeDestination { get; set; }

        public Guid? EmployeeId { get; set; }
    }
}
