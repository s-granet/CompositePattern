using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternHeadFirst.CompositePattern.Abstract;
using CompositePatternHeadFirst.ExtensionMethods;

namespace CompositePatternHeadFirst.CompositePattern.Concrete
{
   public class Menu : MenuComponent
   {
      private List<MenuComponent> menuComponents;
      public string Name { get; private set; }
      public string Description { get; private set; }

      public Menu(string nameParam, string descriptionParam)
      {
         menuComponents = new List<MenuComponent>();
         this.Name = nameParam;
         this.Description = descriptionParam;
      }

      public override void Add(MenuComponent componentParam)
      {
         menuComponents.Add(componentParam);
      }

      public override void Remove(MenuComponent componentParam)
      {
         menuComponents.Remove(componentParam);
      }

      public override string GetName()
      {
         return Name + Environment.NewLine + menuComponents.ConcatReturnedValues(x => x.GetName());
      }

      public override string GetDescription()
      {
         return Description + Environment.NewLine + menuComponents.ConcatReturnedValues(x => x.GetDescription());
      }

      public override double GetPrice()
      {
         return menuComponents.Sum(x => x.GetPrice());
      }

      public override bool IsVegetarian()
      {
         return menuComponents.FirstOrDefault(x => x.IsVegetarian() == false) == null;
      }

      public override void Print()
      {
         Console.WriteLine(Name + " - " + Description);
         menuComponents.ForEach(x => x.Print());
      }
   }
}
