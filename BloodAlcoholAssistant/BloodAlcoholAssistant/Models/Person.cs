using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodAlcoholAssistant.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int NumberOfAlcohols { get; set; }
        public double Weight { get; set; }
        public SexTypes Sex { get; set; }
    }

    public enum SexTypes
    {
        Female,
        Male
    }
}