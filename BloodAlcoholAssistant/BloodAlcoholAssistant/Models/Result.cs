using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodAlcoholAssistant.Models
{
    public class Result
    {
        public double CalculationResult { get; set; }

        public Result(double calculationResult)
        {
            CalculationResult = calculationResult;
        }
    }
}