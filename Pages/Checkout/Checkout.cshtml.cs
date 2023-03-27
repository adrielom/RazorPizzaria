using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPizzaria.Data;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class Checkout : PageModel
    {

        public Checkout(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        private readonly ApplicationDbContext _context;
        public string PizzaName { get; set; }
        public float PizzaPrize { get; set; }

        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.BasePrize = PizzaPrize;
            pizzaOrder.PizzaName = PizzaName;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();

            System.Console.WriteLine(PizzaName);
        }

    }
}