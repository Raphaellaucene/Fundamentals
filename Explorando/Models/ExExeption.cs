using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    //creating stack tracing to resolve an error
    public class ExExeption
    {
        public void Method1() {
            try
            {
                Method2();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exeception resolved..");
            }
        }
        public void Method2() {
            Method3();
        }
        public void Method3() {
            Method4();
        }
        public void Method4() {
            throw new Exception("An exeception occurred.."); //throwing the exception back until catch resolved
        }
    }
}