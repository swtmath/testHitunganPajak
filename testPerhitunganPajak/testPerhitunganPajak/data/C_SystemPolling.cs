namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SystemPolling")]
    public partial class C_SystemPolling
    {
        public Guid Id { get; set; }

        public int? Type { get; set; }

        public int? Method { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string DutyOn { get; set; }

        [StringLength(50)]
        public string DutyOff { get; set; }

        public int? DatePosition { get; set; }

        public int? DateLength { get; set; }

        public int? DateFormat { get; set; }

        [StringLength(10)]
        public string DateSeparator { get; set; }

        public int? DutyOnOffPosition { get; set; }

        public int? DutyOnOffLength { get; set; }

        public int? DutyOnOffFormat { get; set; }

        [StringLength(10)]
        public string DutyOnOffSeparator { get; set; }

        public int? BarcodePosition { get; set; }

        public int? BarcodeLength { get; set; }

        public int? LocationPosition { get; set; }

        public int? LocationLength { get; set; }

        public int? OnOffPosition { get; set; }

        public int? OnOffLength { get; set; }

        [StringLength(50)]
        public string OnOff { get; set; }

        public int? RangeDutyOn { get; set; }

        public int? RangeDutyOff { get; set; }

        [StringLength(10)]
        public string SeparatorChar { get; set; }

        public DateTime? LastRunDate { get; set; }

        public DateTime? NextRunDate { get; set; }

        public bool? RollBackStatus { get; set; }

        public int? DelayMinimum { get; set; }

        public DateTime? UpdateStamp { get; set; }

        public int? OccursEvery { get; set; }

        public int? FrequencyEveryAmount { get; set; }

        public int? FrequencyEvery { get; set; }

        [StringLength(5)]
        public string FrequencyStartingAt { get; set; }

        [StringLength(5)]
        public string FrequencyEndingAt { get; set; }

        public int? ProcessType { get; set; }

        public int? BarcodeOrder { get; set; }

        public int? DateOrder { get; set; }

        public int? DutyOnOffOrder { get; set; }

        public int? LocationOrder { get; set; }

        public int? OnOffOrder { get; set; }

        [StringLength(100)]
        public string OnValue { get; set; }

        [StringLength(100)]
        public string OffValue { get; set; }

        public int? DiffShiftHour { get; set; }

        [StringLength(255)]
        public string WebServiceMachine { get; set; }

        [StringLength(50)]
        public string WebServiceUserName { get; set; }

        [StringLength(50)]
        public string WebServicePassword { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? IgnoreFirstRow { get; set; }

        public int? RangeAfterDutyOn { get; set; }

        public int? RangeAfterDutyOff { get; set; }

        [StringLength(5)]
        public string DayOffDutyOn { get; set; }

        [StringLength(5)]
        public string DayOffDutyOff { get; set; }

        [StringLength(50)]
        public string DateOff { get; set; }

        public bool? PrioritizeOnOffFlag { get; set; }

        [StringLength(50)]
        public string Sheet { get; set; }

        public bool? FlagAutomatic { get; set; }
    }
}
