using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using BloodAlcoholAssistant.Utilities;

namespace BloodAlcoholAssistant.Models
{
    public class Person
    {
        public double WeightAsKilo { get; set; }
        public int NumberOfAlcohols { get; set; }
        public Gender Sex { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "Kobieta")]
        Female,
        [Display(Name = "Mężczyzna")]
        Male
    }
}