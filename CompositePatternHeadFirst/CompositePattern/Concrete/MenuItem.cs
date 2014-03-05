using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternHeadFirst.CompositePattern.Abstract;

namespace CompositePatternHeadFirst.CompositePattern.Concrete
{
   class MenuItem : MenuComponent
   {
      public string Name
      {
         get;
         set;
      }
      public string Description
      {
         get;
         set;
      }
      public bool Vegetarian
      {
         get;
         set;
      }
      public double Price
      {
         get;
         set;
      }

      public MenuItem( string nameParam, string descriptionParam, bool vegetarianParam, double priceParam )
      {
         this.Name = nameParam;
         this.Description = descriptionParam;
         this.Vegetarian = vegetarianParam;
         this.Price = priceParam;
      }

      public override string GetName()
      {
         return Name;
      }

      public override string GetDescription()
      {
         return Description;
      }

      public override double GetPrice()
      {
         return Price;
      }

      public override bool IsVegetarian()
      {
         return Vegetarian;
      }

      public override void Print()
      {
         Console.Write( " " + GetName() );
         Console.Write( "    -- " + GetDescription() );

         if ( IsVegetarian() )
         {
            Console.Write( " (Vegetarian)" );
         }
         Console.WriteLine( string.Format( ", {0:C}", GetPrice() ) );

      }
   }
}
