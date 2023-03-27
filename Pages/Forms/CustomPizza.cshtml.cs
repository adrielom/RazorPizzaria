using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages.Forms
{
    public class CustomPizza : PageModel
    {
        private readonly ILogger<CustomPizza> _logger;

        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrize { get; set; }

        public CustomPizza(ILogger<CustomPizza> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            PizzaPrize = Pizza.PizzaPrize;
            if (Pizza.HasTomatoSauce) PizzaPrize += 1;
            if (Pizza.HasHam) PizzaPrize += 10;
            if (Pizza.HasMushrooms) PizzaPrize += 100;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrize });
        }
    }
}