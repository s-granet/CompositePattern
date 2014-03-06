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

/*         // Create ice cream menu
         var iceCreamMenu = new Menu("Ice cream", "Delicious ice cream");
         var chocolateIceCream = new MenuItem("Chocoate", "MMMM chocoate", true, 2.00);
         var vanillaIceCream = new MenuItem("Vanilla", "MMMM vanilla", true, 3.00);

         // Add ice cream to ice cream menu
         iceCreamMenu.Add(chocolateIceCream);
         iceCreamMenu.Add(vanillaIceCream);

         // Create steak menu
         var steakMenu = new Menu("Steak Menu", "Delicious, delicious steak");
         var tboneSteak = new MenuItem("T-Bone", "big, but mediocre tase", false, 44.00);
         var serloindSteak = new MenuItem("Serloin", "I dont know if i spelled the name correctly", false, 33.00);

         // Add steaks to steak menu
         steakMenu.Add(tboneSteak);
         steakMenu.Add(serloindSteak);*/

         // Create a root menu
         var rootMenu = new Menu("Root", "Holds other menus");
         rootMenu.Add(pizzaMenu);
         rootMenu.Add(saladMenu);
        // rootMenu.Add(iceCreamMenu);
         //rootMenu.Add(steakMenu);

         // Send the root menu to the waitress 
         var waitress = new Waitress(rootMenu);
         waitress.PrintMenu();


         //this should only be on foobar
         Console.ReadLine();


         

         // MASTER PAGE, lets make the master a little longer and see how it goes


         // Lets make masters commit history a little longer, and even a bit longer....

         // this isn't working...

         // what does the network graph look like after a merge


         // MOAR STUFFS

         // why isn't the network graph updating for additional commits?

      }
   }
}


