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
    
    public partial class Food
    {
        public Food()
        {
            this.tbl_food_logs = new HashSet<FoodLog>();
            this.tbl_food_nutrition_logs = new HashSet<FoodNutrientLogs>();
        }
    
        public int FoodID { get; set; }
        public int SourceID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufactureName { get; set; }
    
        public virtual FoodGroup tbl_food_groups { get; set; }
        public virtual ICollection<FoodLog> tbl_food_logs { get; set; }
        public virtual ICollection<FoodNutrientLogs> tbl_food_nutrition_logs { get; set; }
    }
}
