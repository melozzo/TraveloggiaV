//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATRAVELOGGIA_MVC.WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> AccountCreateDate { get; set; }
        public string OpenID { get; set; }
        public Nullable<int> CreatedByMapID { get; set; }
        public Nullable<int> TraveloggiaEditionID { get; set; }
        public string TraveloggiaEdition { get; set; }
    }
}
