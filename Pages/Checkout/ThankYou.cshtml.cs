using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPizzaria.Pages.Checkout
{
    public class ThankYou : PageModel
    {
        private readonly ILogger<ThankYou> _logger;

        public ThankYou(ILogger<ThankYou> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}