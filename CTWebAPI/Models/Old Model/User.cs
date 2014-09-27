//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTWebAPI.Models.Old_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.tbl_activity_logs = new HashSet<ActivityLog>();
            this.tbl_food_logs = new HashSet<FoodLog>();
            this.tbl_metric_logs = new HashSet<MetricLogs>();
        }
    
        public int UserID { get; set; }
        public System.DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool Admin { get; set; }
        public System.DateTime CreationTimestamp { get; set; }
        public int ActivityLevelType { get; set; }
        public int Personality { get; set; }
    
        public virtual ICollection<ActivityLog> tbl_activity_logs { get; set; }
        public virtual ICollection<FoodLog> tbl_food_logs { get; set; }
        public virtual ICollection<MetricLogs> tbl_metric_logs { get; set; }
    }
}