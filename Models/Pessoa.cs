using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    public class People
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void Greetings(){

            Console.WriteLine($"Hello, my name is {Name}, and I'm {Age} years old");
        }
    }
}