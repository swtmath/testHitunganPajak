namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingDetail")]
    public partial class TrainingDetail
    {
        public Guid Id { get; set; }

        public Guid TrainingId { get; set; }

        public string Description { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string FromDescription { get; set; }

        public string ToDescription { get; set; }

        public string TypeOfTransportation { get; set; }

        public DateTime? Date { get; set; }

        public string City { get; set; }

        public string ArrangementBy { get; set; }

        public int? LineNumber { get; set; }

        public int? DetailType { get; set; }
    }
}
