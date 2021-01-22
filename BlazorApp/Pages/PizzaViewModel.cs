using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class PizzaViewModel
    {
        public string AccountNumber { get; set; }
        public int RecipeYear { get; set; }
        public string Size { get; set; }
        public decimal Cost { get; set; }
    }
}
