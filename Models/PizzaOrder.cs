using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPizzaria.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrize { get; set; }
    }
}