//arquivo de classe c# onde fica a codificação
//é o ponto de entrada do programa
// See https://aka.ms/new-console-template for more information

using Fundamentals.Models;

People pessoa1 = new People();

pessoa1.Name = "Carol";
pessoa1.Age = 29;
pessoa1.Greetings();

//casting -> conversão
//usando classe convert e metodo toInt32 
int a = Convert.ToInt32("5");

int b = int.Parse("5");