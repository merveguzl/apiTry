//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiTry.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experience_Table
    {
        public int experience_id { get; set; }
        public int user_id { get; set; }
        public string experience_name { get; set; }
        public string experience_text { get; set; }
        public string experience_photo { get; set; }
        public string experience_location { get; set; }
    
        public virtual User_Table User_Table { get; set; }
    }
}
