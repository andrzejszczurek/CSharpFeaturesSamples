using CSharpFeaturesSamples.Algorithms;
using CSharpFeaturesSamples.Features;
using CSharpFeaturesSamples.Features.Arrays;
using CSharpFeaturesSamples.Features.Indexier;
using System;

namespace CSharpFeaturesSamples
{
   class Program
   {
      static void Main(string[] args)
      {
         //YieldSample ys = new YieldSample();
         //ArraySample.TryChangeArrayPointerToAnotherArray();
         //DestructorSample ds = new DestructorSample();
         //DisposableSample.RunSample();
         //GC.Collect();

         //var indexierSample = new IndexierSample("Testowy string");

         //for (int i = 0; i < indexierSample.Length; i++)
         //{
         //   Console.WriteLine(indexierSample[i]);
         //}


         var x = new AlgorithmsSample();
         var r = x.BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 10);

         Console.ReadKey();
      }
   }
}
