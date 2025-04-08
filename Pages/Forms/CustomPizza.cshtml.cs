using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

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
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Pepperoni) PizzaPrice += 3;
            if (Pizza.Mushrooms) PizzaPrice += 2;
            if (Pizza.Olives) PizzaPrice += 2;
            if (Pizza.Pineapple) PizzaPrice += 2;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Bacon) PizzaPrice += 3;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});

        }
    }
}
