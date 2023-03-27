using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPizzaria.Data;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages
{
    public class Orders : PageModel
    {
        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDbContext _context;

        public Orders(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}