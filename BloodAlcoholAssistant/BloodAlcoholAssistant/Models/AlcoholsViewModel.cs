using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodAlcoholAssistant.Models
{
    public class AlcoholsViewModel
    {
        public List<Alcohol> ListOfAlcohols { get; set; }

        public AlcoholsViewModel(int length)
        {
            ListOfAlcohols = new List<Alcohol>(length);
        }
    }
}