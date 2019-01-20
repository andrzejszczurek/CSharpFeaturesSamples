using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features
{
   public static class MethodSamples
   {
      public static int OutValueParam(out int output)
      {
         // if out keyword is used, value must be initialized inside method
         output = 1;
         return output;
      }

      public static int RefValueParam(ref int output)
      {
         return output;
      }
   }
}
