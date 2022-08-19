using API_INTRO.Models;

namespace API_INTRO.Repositories
{
    public class PizzaRepository : IPizzaRepostitory
    {
        private static List<Pizza> _pizzaData = new()
        {
            new Pizza()
            {
                Id = 1,
                CrustType = "thick",
                Extras = "",
                Size = "Large",
                Toppings = new() { "perreroni", "mushrooms"
                }
            },
            new Pizza()
            {
                Id=2,
                CrustType = "thin",
                Extras = "red pepper flakes",
                Size = "Small",
                Toppings = new() { "perreroni", "sausage"
                }
            },
            new Pizza()
            {
                Id=3,
                CrustType = "hand tossed",
                Extras = "cheese",
                Size = "Medium",
                Toppings = new() { "cheese"
                }
            },
            new Pizza()
            {   
                Id=4,
                CrustType = "extra thick",
                Extras = "",
                Size = "Large",
                Toppings = new() { "perreroni", "mushrooms"
                }
            },
    };

        public List<Pizza> GetAll()
        {
            return _pizzaData;
        }

        internal List<Pizza> GetAll()
        {
            var retVal = new List<Pizza>();

            return retVal;
        }

        public void Create()
        {
            _pizzaData.Add(new Pizza()
            {
                CrustType = "thick",
                Extras = "",
                Size = "Large",
                Toppings = new() { "perreroni", "mushrooms"
                }
            });
        }
    }
}
