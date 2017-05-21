using System.ComponentModel.DataAnnotations;

namespace BloodAlcoholAssistant.Models
{
    public class Alcohol
    {
        public string Name { get; set; }

        [Range(0.0, double.MaxValue)]
        public double Percent { get; set; }

        [Range(0.0, double.MaxValue)]
        public double LitresVolume { get; set; }
    }
}