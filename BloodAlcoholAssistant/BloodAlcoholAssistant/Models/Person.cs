using System.ComponentModel.DataAnnotations;

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