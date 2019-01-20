using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features.Arrays
{
   public class ArraySample
   {
      public static void TestArrayRef()
      {
         var arr = new int[] { 1, 2, 3 };
         PrintArray(arr);
         ArrayModifier(arr);
         PrintArray(arr);
      }

      private static void ArrayModifier(int[] arr)
      {
         for (int i = 0; i < arr.Length; i++)
         {
            arr[i] = ++arr[i];
         }
      }

      private static void PrintArray<T>(T[] arr)
      {
         foreach (var item in arr)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();
      }

      public static void TryChangeArrayPointerToAnotherArray()
      {
         int[] arr = new int[] { 1, 2, 3 };
         PrintArray(arr);
         ChangeArrayReference(ref arr);
         PrintArray(arr);
      }

      private static void ChangeArrayReference(int[] arr)
      {
         arr = new int[] { 5, 6, 7 };
      }

      private static void ChangeArrayReference(ref int[] arr)
      {
         arr = new int[] { 5, 6, 7 };
      }

   }
}
