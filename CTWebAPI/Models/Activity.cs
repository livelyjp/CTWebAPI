//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public Activity()
        {
            this.tbl_activity_logs = new HashSet<ActivityLog>();
        }
    
        public int ActivityID { get; set; }
        public string Name { get; set; }
        public decimal CalorieBurnRate { get; set; }
        public string ImageUrl { get; set; }
    
        public virtual ICollection<ActivityLog> tbl_activity_logs { get; set; }
    }
}
