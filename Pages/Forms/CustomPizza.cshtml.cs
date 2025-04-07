using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 1;
            if (Pizza.Mushrooms) PizzaPrice += 1;
            if (Pizza.Olives) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 2;
            if (Pizza.Bacon) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});

        }
    }
}
