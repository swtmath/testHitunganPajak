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
    
    public partial class C_EmployeeDependent
    {
        public System.Guid Id { get; set; }
        public System.Guid EmployeeId { get; set; }
        public string FullName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string HandPhone { get; set; }
        public string Email { get; set; }
        public Nullable<int> Religion { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> BloodType { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Nationality { get; set; }
        public string Ethnic { get; set; }
        public string NPWP { get; set; }
        public Nullable<int> Relation { get; set; }
        public Nullable<bool> PassAway { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<bool> Claim { get; set; }
        public Nullable<int> Education { get; set; }
        public string Occupation { get; set; }
        public string IdNumber { get; set; }
        public Nullable<System.DateTime> IdNumberExpire { get; set; }
    
        public virtual C_Employee C_Employee { get; set; }
    }
}
