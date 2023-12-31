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
    
    public partial class Request
    {
        public int ID { get; set; }
        public string Module { get; set; }
        public string Subject { get; set; }
        public string Creator { get; set; }
        public Nullable<int> Importance { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> Interlocutor { get; set; }
        public string AssociatedPerson { get; set; }
        public string Explanation { get; set; }
        public string Platform { get; set; }
        public string Type { get; set; }
        public string RequestType { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<int> FileID { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
    }
}
