using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FrontEnd.Pages
{
    public class PersonalClima : PageModel
    {
        private readonly ILogger<PersonalClima> _logger;

        public PersonalClima(ILogger<PersonalClima> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
