﻿using System.ComponentModel.DataAnnotations;
using CTWebAPI.Models.MetaData;

namespace CTWebAPI.Models
{
    [MetadataType(typeof (FoodMetaData))]
    public partial class Food
    {
    }
}