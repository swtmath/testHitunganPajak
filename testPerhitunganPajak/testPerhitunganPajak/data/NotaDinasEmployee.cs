namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaDinasEmployee")]
    public partial class NotaDinasEmployee
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NotaDinasId { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? JobId { get; set; }

        public Guid? ClassId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(5)]
        public string StartTime { get; set; }

        [StringLength(5)]
        public string EndTime { get; set; }

        public bool? MultiDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? MealAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransportAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? AirPortTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FDayAmount { get; set; }

        public int? LineNumber { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public DateTime? TaskEndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? OMealDayOffAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OMealWorkingDayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ODayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OFDayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FOtherAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TicketAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FTicketAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FHotelAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PassportAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? VisaAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FVisaAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelTransitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FHotelTransitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsuranceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FInsuranceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherCurrencyRate { get; set; }

        public Guid? OtherCurrencyId { get; set; }

        public int? OtherFundType { get; set; }

        [StringLength(100)]
        public string OtherFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TicketCurrencyRate { get; set; }

        public Guid? TicketCurrencyId { get; set; }

        public int? TicketFundType { get; set; }

        [StringLength(100)]
        public string TicketFundDescription { get; set; }

        public Guid? HotelCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelCurrencyRate { get; set; }

        public int? HotelFundType { get; set; }

        [StringLength(100)]
        public string HotelFundDescription { get; set; }

        public int? PassportFundType { get; set; }

        [StringLength(100)]
        public string PassportFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? VisaCurrencyRate { get; set; }

        public Guid? VisaCurrencyId { get; set; }

        public int? VisaFundType { get; set; }

        [StringLength(100)]
        public string VisaFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? HotelTransitCurrencyRate { get; set; }

        public Guid? HotelTransitCurrencyId { get; set; }

        public int? HotelTransitFundType { get; set; }

        [StringLength(100)]
        public string HotelTransitFundDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsuranceCurrencyRate { get; set; }

        public Guid? InsuranceCurrencyId { get; set; }

        public int? InsuranceFundType { get; set; }

        [StringLength(100)]
        public string InsuranceFundDescription { get; set; }

        public bool? Paid { get; set; }
    }
}
