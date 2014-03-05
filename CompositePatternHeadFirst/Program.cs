using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternHeadFirst.CompositePattern.Abstract;
using CompositePatternHeadFirst.CompositePattern.Concrete;

namespace CompositePatternHeadFirst
{
   class Program
   {
      static void Main( string[] args )
      {
         // Create pizza menu
         var pizzaMenu = new Menu("Pizza Menu", "This should be a base pizza menu");
         var meatPizza = new MenuItem("Meaty", "This is a meat pizza", false, 5.00);
         var cheesePizza = new MenuItem("Cheese Pizza!", "This is a cheese pizza", true, 3.00);

         // Add pizzas to pizza menu
         pizzaMenu.Add(meatPizza);
         pizzaMenu.Add(cheesePizza);

         // Create Salad Menu
         var saladMenu = new Menu("Salad Menu", "This should be a base salad menu");
         var chefSalad = new MenuItem("Chef", "Has lots of good.. chefy stuff", false, 10.00);
         var gardenSalad = new MenuItem("Garden", "Has lots of veggies", true, 4.00);

         // Add Salads to Salad Menu
         saladMenu.Add(chefSalad);
         saladMenu.Add(gardenSalad);

         // Create a root menu
         var rootMenu = new Menu("Root", "Holds other menus");
         rootMenu.Add(pizzaMenu);
         rootMenu.Add(saladMenu);

         // Send the root menu to the waitress 
         var waitress = new Waitress(rootMenu);
         waitress.PrintMenu();

         Console.ReadLine();

      }
   }
}
