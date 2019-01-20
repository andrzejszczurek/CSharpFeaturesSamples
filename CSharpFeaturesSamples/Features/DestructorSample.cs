using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features
{
   public class DestructorSample
   {
      public DestructorSample()
      {
         Console.WriteLine($"Wowołano konstruktor klasy {nameof(DestructorSample)}");
      }

      ~DestructorSample()
      {
         Console.WriteLine($"Wowołano destruktor klasy {nameof(DestructorSample)}");
      }

   }
}
