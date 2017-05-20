using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using BloodAlcoholAssistant.Models;

namespace BloodAlcoholAssistant.Utilities
{
    public class AlcoholValueCalculator
    {
        private const double FemaleConstat = 0.55;
        private const double MaleConstant = 0.68;

        public double ReturnValueByGender(Person person, double alcoholValue)
        {
            var factor = person.Sex == Gender.Female
                ? FemaleConstat
                : MaleConstant;

            return alcoholValue / (person.WeightAsKilo * factor);
        }
    }
}