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
    
    public partial class MoldDocument
    {
        public int ID { get; set; }
        public byte[] DOCUMENT { get; set; }
        public string PROJECT_CODE { get; set; }
        public string USERNAME { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public string TYPE { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
