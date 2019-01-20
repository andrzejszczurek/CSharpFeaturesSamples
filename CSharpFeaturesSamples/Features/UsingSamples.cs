using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features
{
   public class UsingSamples
   {
      public static void UsingStatementUsage(string text)
      {
         using (StringReader sr = new StringReader(text))
         {
            Console.WriteLine(sr.ReadLine());
         }
      }

      public static void UsingImplBehindScenes(string text)
      {
         {
            StringReader sr = new StringReader(text);
            try
            {
               Console.WriteLine(sr.ReadLine());
            }
            finally
            {
               sr?.Dispose();
            }
         }
      }
   }
}
