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
    
    public partial class FoodNutrientLog
    {
        public int NurtientLogID { get; set; }
        public int FoodID { get; set; }
        public int NurtientID { get; set; }
        public decimal Value { get; set; }
    
        public virtual Food tbl_foods { get; set; }
        public virtual Nutrient tbl_nutrients { get; set; }
    }
}