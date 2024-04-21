//arquivo de classe c# onde fica a codificação
//é o ponto de entrada do programa
// See https://aka.ms/new-console-template for more information

using Fundamentals.Models;

People pessoa1 = new People();

pessoa1.Name = "Carol";
pessoa1.Age = 29;
pessoa1.Greetings();

//casting -> conversão
//a diferença do tratamento do nulo, em convert retorna 0, parse da erro (não pode ser nulo)
//usando classe convert e metodo toInt32 
int a = Convert.ToInt32("5");

//parse
int b = int.Parse("5");

//para converter para string só usar toString pois ja vem de herança da classe mae (classe object)
string c = a.ToString();

//cast implicito, de int para double, long faz diretamente

string d = "15-";

int e = 0;

//tentar converter se não der, a saida sera e
int.TryParse(d, out e);