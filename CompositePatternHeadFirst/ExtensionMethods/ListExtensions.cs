using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternHeadFirst.ExtensionMethods
{
   public static class ListExtensions
   {
      public static string ConcatReturnedValues<T>( this IEnumerable<T> listParam, Func<T, string> toExecute )
      {
         var tmp = new StringBuilder();

         foreach ( var item in listParam )
         {
            tmp.Append( toExecute( item ) );
         }

         return tmp.ToString();
      }
   }
}