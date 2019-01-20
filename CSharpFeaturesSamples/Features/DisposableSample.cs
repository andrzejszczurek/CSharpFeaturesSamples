using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features
{
   public class DisposableSample
   {
      public static void RunSample()
      {
         Console.WriteLine("Przed usingiem");
         using (var ds = new DisSample())
         {
            Console.WriteLine(ds.Echo($"Użytkowanie klasy {nameof(DisSample)}"));
         }
         Console.WriteLine("Po usingu");
      }

      private class DisSample : IDisposable
      {
         private bool disposed = false;

         public DisSample()
         {
            Console.WriteLine($"Tworzenie obiektu {nameof(DisSample)}");
         }

         ~DisSample()
         {
            Console.WriteLine($"Finalizowanie obieku {nameof(DisSample)}");
         }

         public void Dispose()
         {
            lock (this) // żeby wątek GC nie wlazł
            {
               if (!disposed)
               {
                  Console.WriteLine($"Zwalnianie zasobów obiektu {nameof(DisSample)}");
               }
               disposed = true;
               GC.SuppressFinalize(this); // zapobiegnie wywołaniu destruktora
            }
         }

         public T Echo<T>(T value) => value;

      }
   }

}
