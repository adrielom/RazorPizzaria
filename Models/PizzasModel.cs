using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPizzaria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float PizzaPrize { get; set; }
        public bool HasTomatoSauce { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasMushrooms { get; set; }
        public bool HasTuna { get; set; }
        public bool HasPineapple { get; set; }
        public bool HasHam { get; set; }
        public bool HasBeef { get; set; }
        public float FinalPrize { get; set; }
    }
}