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
    
    public partial class TrainingDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid TrainingId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string FromDescription { get; set; }
        public string ToDescription { get; set; }
        public string TypeOfTransportation { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string City { get; set; }
        public string ArrangementBy { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<int> DetailType { get; set; }
    }
}
