using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesSamples.Features.Indexier
{
   public class IndexierSample
   {
      private readonly char[] m_str;

      public int Length { get; set; }

      public IndexierSample(string str)
      {
         m_str = str.ToCharArray();
         Length = m_str.Length;
      }

      public char this[int index]
      {
         get
         {
            return m_str[index];
         }

         set
         {
            m_str[index] = value;
         }
      }
   }
}
