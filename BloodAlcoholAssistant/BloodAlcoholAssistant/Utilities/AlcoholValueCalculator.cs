using System;
using System.Linq;
using BloodAlcoholAssistant.Converters;
using BloodAlcoholAssistant.Models;

namespace BloodAlcoholAssistant.Utilities
{
    /* zgodnie z: http://www.wikihow.com/Calculate-Blood-Alcohol-Content-(Widmark-Formula)
     * i z pominieciem czasu tak, jak przy omawianiu ;

     * wyniki byly porownywane z tymi uzyskanymi tutaj:
     * http://educalcool.qc.ca/en/facts-tips-and-tools/tools/blood-alcohol-calculator/#.WSDOwMakIwE
     * zgadzaja sie z wylaczeniem uplywu czasu, ktory nie mial
     * byc uwzgledniony (PS na stronie wyzej podaje w procentach) */

    public class AlcoholValueCalculator
    {
        private const double FemaleConstat = 0.55;
        private const double MaleConstant = 0.68;

        public static double CalculateRealAlcoholValue(Person person, 
            AlcoholsViewModel alcoholVm)
        {
            try
            {
                var sumOfAlcohols = alcoholVm.ListOfAlcohols
                    .Sum(alcoholItem => PercentWithVolumeToGramOfAlcohol
                        .ReturnGramsOfAlcohol(alcoholItem.LitresVolume,
                            alcoholItem.Percent));

                return ReturnValue(person, sumOfAlcohols);
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }

        public static double ReturnValue(Person person, double alcoholValue)
        {
            var factor = person.Sex == Gender.Female
                ? FemaleConstat
                : MaleConstant;

            return Math.Round(alcoholValue / (person.WeightAsKilo * factor), 2);
        }
    }
}