using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    public class Calculator
    {
        public void Sum(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Sub(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Mult(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void Div(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno,4)}");
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {coseno}");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {tangente}");
        }
    }
}