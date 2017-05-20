using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodAlcoholAssistant.Models
{
    public class Alcohol
    {
        public string Name { get; set; }
        public double Percent { get; set; }
        public double LitresVolume { get; set; }
    }
}