using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features
{
   public class YieldSample
   {
      private static IList<int> list = new List<int>();

      public YieldSample()
      {
         FillList();
      }

      public void PrintList()
      {
         foreach (var item in list)
            Console.WriteLine($"List element value: {item}");
      }

      public void PrintListWithFilter(int greaterThan)
      {
         foreach (var item in FilterListWithYield(greaterThan))
            Console.WriteLine($"List element value: {item}");
      }

      private static void FillList()
      {
         Random random = new Random();

         for (int i = 0; i < 10; i++)
            list.Add(random.Next(0, 1001));
      }

      private IEnumerable<int> FilterListWithoutYield(int greaterThan)
      {
         List<int> templist = new List<int>();
         foreach (var item in list)
         {
            if (item > greaterThan)
               templist.Add(item);
         }
         return templist;
      }

      // better because dont need use temp list to return result
      private IEnumerable<int> FilterListWithYield(int greaterThan)
      {
         foreach (var item in list)
         {
            if (item > greaterThan)
               yield return item;
         }
      }

      public IEnumerable<int> YieldReturn()
      {
         foreach (var item in list)
            yield return item;

      }

      public IEnumerable<int> RunningTotal(int n)
      {
         int total = 0;
         foreach (var item in list)
         {
            total += item;
            yield return total;
         }
      }

   }
}
