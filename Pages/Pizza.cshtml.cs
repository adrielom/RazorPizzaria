using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() {
            new PizzasModel() { ImageTitle="Margerita", PizzaName="Margerita", PizzaPrize=2, HasTomatoSauce=true, HasHam=false },
            new PizzasModel() { ImageTitle="Bolognese", PizzaName="Bolognese", PizzaPrize=5, HasTomatoSauce=true, HasHam=true },
            new PizzasModel() { ImageTitle="Mushroom", PizzaName="Mushroom", PizzaPrize=10, HasTomatoSauce=false, HasHam=false }
    };
        private readonly ILogger<PizzaModel> _logger;

        public PizzaModel(ILogger<PizzaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}