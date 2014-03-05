using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternHeadFirst.CompositePattern.Abstract;

namespace CompositePatternHeadFirst
{
   public class Waitress
   {
      private MenuComponent allMenus;

      public Waitress(MenuComponent allMenusParam)
      {
         this.allMenus = allMenusParam;
      }

      public void PrintMenu()
      {
         allMenus.Print();
      }

      public void PrintNames()
      {
         Console.WriteLine(allMenus.GetName());
      }

      public void PrintDescriptions()
      {
         Console.WriteLine(allMenus.GetDescription());
      }

      public void PrintPrices()
      {
         Console.WriteLine(allMenus.GetPrice());
      }

      public void PrintVegetarianism()
      {
         Console.WriteLine(allMenus.IsVegetarian());
      }

   }
}
