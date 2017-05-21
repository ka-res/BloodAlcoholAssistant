using BloodAlcoholAssistant.Converters;
using BloodAlcoholAssistant.Utilities;

namespace BloodAlcoholAssistant.Models
{
    public class ResultViewModel
    {
        public string CalculationResult { get; set; }

        public void GetResult(Person person, AlcoholsViewModel alcoholVm)
        {
            CalculationResult = ResultToText.GetResultValue(
                AlcoholValueCalculator.CalculateRealAlcoholValue(
                    person, alcoholVm));
        }
    }
}
