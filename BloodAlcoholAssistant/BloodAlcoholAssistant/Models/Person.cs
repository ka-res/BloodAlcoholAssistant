using System.ComponentModel.DataAnnotations;

namespace BloodAlcoholAssistant.Models
{
    public class Person
    {
        [Range(0.0, 250.0, ErrorMessage = "Waga musi być z przedziału od 0 do 250 kg")]
        public double WeightAsKilo { get; set; }

        [Range(0.0, 100.0, ErrorMessage = "Ilość alkoholi należy podać z przedziału od 0 do 100")]
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