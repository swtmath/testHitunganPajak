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
    
    public partial class LNDPlanningDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid LNDPlanningId { get; set; }
        public string WorkGoals { get; set; }
        public string ActualCondition { get; set; }
        public string DevelopmentGoals { get; set; }
        public string Skill { get; set; }
        public Nullable<int> TypeMethod { get; set; }
        public string Topic { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<int> Type { get; set; }
        public string TypeMethodDescription { get; set; }
        public Nullable<System.Guid> LNDTopicId { get; set; }
        public Nullable<decimal> LNDTopicCostAmount { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
    
        public virtual LNDPlanning LNDPlanning { get; set; }
    }
}
