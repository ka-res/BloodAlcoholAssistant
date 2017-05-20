using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodAlcoholAssistant.Converters
{
    public class PercentWithVolumeToGramOfAlcohol
    {
        public static double ReturnGramsOfAlcohol(double volumeOfDrinkAsLiter, 
            double percentOfAlcohol)
        {
            return volumeOfDrinkAsLiter * percentOfAlcohol * 7.89;
            /*tutaj juz uproscilem wzor bo jest w przepisie
                * ...*1000/100*0.789=10*0.789=7.89
                * unikam dzieki temu marnowania czasu procka*/ 
        }
    }
}