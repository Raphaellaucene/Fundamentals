using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class ReadFile
    { //using tupla for return an array, bool and total of lines for method
        public (bool Sucess, string[] Lines, int TotalLines) ReadArq(string path) {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch (System.Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}