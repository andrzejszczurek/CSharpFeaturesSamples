using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Algorithms
{
   class AlgorithmsSample
   {
      public T? BinarySearch<T>(T[] arr, T item) where T: struct, IComparable
      {
         int low = 0;
         int high = arr.Length - 1;

         while (low <= high)
         {
            int mid = (high + low) / 2;
            T value = arr[mid];
            var result = value.CompareTo(item);
            if (result == 0)
               return value;
            else
            {
               if (result == -1)
                  low = mid + 1;
               else
                  high = mid - 1;
            }
         }
         return null;
      }


   }
}
