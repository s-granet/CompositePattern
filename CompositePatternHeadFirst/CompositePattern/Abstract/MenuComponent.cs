using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternHeadFirst.CompositePattern.Abstract
{
   public abstract class MenuComponent
   {
      public virtual void Add(MenuComponent componentParam)
      {
         throw new NotImplementedException();
      }

      public virtual void Remove(MenuComponent componentParam)
      {
         throw new NotImplementedException();
      }

      public virtual MenuComponent GetChild(int i)
      {
         throw new NotImplementedException();
      }

      public virtual string GetName()
      {
         throw new NotImplementedException();
      }

      public virtual string GetDescription()
      {
         throw new NotImplementedException();
      }

      public virtual double GetPrice()
      {
         throw new NotImplementedException();
      }

      public virtual bool IsVegetarian()
      {
         throw new NotImplementedException();
      }

      public virtual void Print()
      {
         throw new NotImplementedException();
      }
   }
}
