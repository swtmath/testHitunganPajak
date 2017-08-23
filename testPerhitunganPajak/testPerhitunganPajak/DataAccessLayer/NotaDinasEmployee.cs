//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testPerhitunganPajak.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotaDinasEmployee
    {
        public System.Guid Id { get; set; }
        public System.Guid NotaDinasId { get; set; }
        public Nullable<System.Guid> EmployeeId { get; set; }
        public Nullable<System.Guid> BranchId { get; set; }
        public Nullable<System.Guid> OrganizationId { get; set; }
        public Nullable<System.Guid> JobId { get; set; }
        public Nullable<System.Guid> ClassId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Nullable<bool> MultiDate { get; set; }
        public Nullable<decimal> MealAmount { get; set; }
        public Nullable<decimal> TransportAmount { get; set; }
        public Nullable<decimal> AirPortTaxAmount { get; set; }
        public Nullable<decimal> DayAmount { get; set; }
        public Nullable<decimal> FDayAmount { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<System.DateTime> TaskStartDate { get; set; }
        public Nullable<System.DateTime> TaskEndDate { get; set; }
        public Nullable<decimal> OMealDayOffAmount { get; set; }
        public Nullable<decimal> OMealWorkingDayAmount { get; set; }
        public Nullable<decimal> ODayAmount { get; set; }
        public Nullable<decimal> OFDayAmount { get; set; }
        public Nullable<decimal> OtherAmount { get; set; }
        public Nullable<decimal> FOtherAmount { get; set; }
        public Nullable<decimal> TicketAmount { get; set; }
        public Nullable<decimal> FTicketAmount { get; set; }
        public Nullable<decimal> HotelAmount { get; set; }
        public Nullable<decimal> FHotelAmount { get; set; }
        public Nullable<decimal> PassportAmount { get; set; }
        public Nullable<decimal> VisaAmount { get; set; }
        public Nullable<decimal> FVisaAmount { get; set; }
        public Nullable<decimal> HotelTransitAmount { get; set; }
        public Nullable<decimal> FHotelTransitAmount { get; set; }
        public Nullable<decimal> InsuranceAmount { get; set; }
        public Nullable<decimal> FInsuranceAmount { get; set; }
        public Nullable<decimal> OtherCurrencyRate { get; set; }
        public Nullable<System.Guid> OtherCurrencyId { get; set; }
        public Nullable<int> OtherFundType { get; set; }
        public string OtherFundDescription { get; set; }
        public Nullable<decimal> TicketCurrencyRate { get; set; }
        public Nullable<System.Guid> TicketCurrencyId { get; set; }
        public Nullable<int> TicketFundType { get; set; }
        public string TicketFundDescription { get; set; }
        public Nullable<System.Guid> HotelCurrencyId { get; set; }
        public Nullable<decimal> HotelCurrencyRate { get; set; }
        public Nullable<int> HotelFundType { get; set; }
        public string HotelFundDescription { get; set; }
        public Nullable<int> PassportFundType { get; set; }
        public string PassportFundDescription { get; set; }
        public Nullable<decimal> VisaCurrencyRate { get; set; }
        public Nullable<System.Guid> VisaCurrencyId { get; set; }
        public Nullable<int> VisaFundType { get; set; }
        public string VisaFundDescription { get; set; }
        public Nullable<decimal> HotelTransitCurrencyRate { get; set; }
        public Nullable<System.Guid> HotelTransitCurrencyId { get; set; }
        public Nullable<int> HotelTransitFundType { get; set; }
        public string HotelTransitFundDescription { get; set; }
        public Nullable<decimal> InsuranceCurrencyRate { get; set; }
        public Nullable<System.Guid> InsuranceCurrencyId { get; set; }
        public Nullable<int> InsuranceFundType { get; set; }
        public string InsuranceFundDescription { get; set; }
        public Nullable<bool> Paid { get; set; }
    }
}
