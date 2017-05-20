using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BloodAlcoholAssistant.Models;

namespace BloodAlcoholAssistant.Mappers
{
    public class PersonMapper
    {
        public Person Create(double weight, int number, Gender sex)
        {
            return new Person
            {
                WeightAsKilo = weight,
                NumberOfAlcohols = number,
                Sex = sex
            };
        }
    }
}