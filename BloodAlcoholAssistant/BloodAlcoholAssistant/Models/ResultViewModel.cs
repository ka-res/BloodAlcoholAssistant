using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BloodAlcoholAssistant.Converters;
using BloodAlcoholAssistant.Utilities;

namespace BloodAlcoholAssistant.Models
{
    public class ResultViewModel
    {
        public double CalculationResult { get; set; }

        public ResultViewModel(Person person, AlcoholsViewModel alcoholVm)
        {
            var sumOfAlcohols = alcoholVm.ListOfAlcohols
                .Sum(alcoholItem => 
                PercentWithVolumeToGramOfAlcohol.ReturnGramsOfAlcohol(
                    alcoholItem.LitresVolume, alcoholItem.Percent));

            CalculationResult =
                AlcoholValueCalculator.ReturnValueByGender(person, sumOfAlcohols);
        }
    }
}