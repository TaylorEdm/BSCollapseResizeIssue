using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.GroupByMany;

namespace BlazorApp.Pages
{
    public class PizzaWorldViewModel
    {
        public IGroupByManyResult<PizzaViewModel> GroupedPizzas { get; set; }

        public PizzaWorldViewModel()
        {
            var details = new List<PizzaViewModel>
            {
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2015, Size = "15", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2015, Size = "15", Cost = 17.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2016, Size = "15", Cost = 11.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2017, Size = "15", Cost = 12.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2018, Size = "17", Cost = 13.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2019, Size = "20", Cost = 14.00m },
                new PizzaViewModel { AccountNumber = "PIZZ001", RecipeYear = 2020, Size = "15", Cost = 15.00m },

                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2015, Size = "19", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2015, Size = "19", Cost = 18.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2016, Size = "15", Cost = 11.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2017, Size = "12", Cost = 12.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2018, Size = "17", Cost = 13.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2019, Size = "20", Cost = 14.00m },
                new PizzaViewModel { AccountNumber = "PIZZ002", RecipeYear = 2020, Size = "20", Cost = 15.00m },

                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2015, Size = "15", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2015, Size = "17", Cost = 14.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2016, Size = "16", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2017, Size = "12", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2018, Size = "12", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2019, Size = "12", Cost = 10.00m },
                new PizzaViewModel { AccountNumber = "PIZZ003", RecipeYear = 2020, Size = "12", Cost = 10.00m }
            };

            GroupedPizzas = details.OrderBy(p => p.AccountNumber).ThenBy(p => p.RecipeYear).ThenBy(p => p.Size).ThenBy(p => p.Cost)
                .GroupByMany(p => p.AccountNumber, p => p.RecipeYear, p => p.Size, p => p.Cost);
        }
    }
}
