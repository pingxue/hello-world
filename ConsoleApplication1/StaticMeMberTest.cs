using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class StaticMeMberTest
   {
       public static int StaticI = 0;
       public static int StaticII = 0;

       public StaticMeMberTest()
       {
           StaticII = 0;
       }

       public int GetNextI()
       {
           return ++StaticI;
       }

       public int GetNextII()
       {
           return ++StaticII;
       }
   }
}
