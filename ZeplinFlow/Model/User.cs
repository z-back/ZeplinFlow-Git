//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeplinFlow.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NetUser { get; set; }
        public string NetPass { get; set; }
        public Nullable<bool> Status { get; set; }
        public string PersonalName { get; set; }
        public string Email { get; set; }
        public Nullable<int> NetUserId { get; set; }
        public Nullable<bool> DefaultPassword { get; set; }
        public Nullable<int> FiyatGor { get; set; }
        public string PlasiyerCode { get; set; }
        public string ErpUsername { get; set; }
        public string ErpPassword { get; set; }
    }
}