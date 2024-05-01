// See https://aka.ms/new-console-template for more information

using Fundamentals.Models;

string options;
bool showmenu = true;

while(showmenu){
    Console.Clear();
    Console.WriteLine("Enter your choice: ");
    Console.WriteLine("1 - Register Customers");
    Console.WriteLine("2 - Search Customers");
    Console.WriteLine("3 - Delete Customers");
    Console.WriteLine("4 - Exit");

    options = Console.ReadLine();

    switch(options){
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0); //encerra por completo
            showmenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

Console.WriteLine("Program is closed..");


//Calculator calc = new Calculator();

//calc.Sum(10, 30);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// People pessoa1 = new People();

// pessoa1.Name = "Carol";
// pessoa1.Age = 29;
// pessoa1.Greetings();

//casting -> conversão
//ctrl + K + C comenta
//a diferença do tratamento do nulo, em convert retorna 0, parse da erro (não pode ser nulo)
//usando classe convert e metodo toInt32 
// int a = Convert.ToInt32("5");

// //parse
// int b = int.Parse("5");

// //para converter para string só usar toString pois ja vem de herança da classe mae (classe object)
// string c = a.ToString();

// //cast implicito, de int para double, long faz diretamente

// string d = "15-";

// int e = 0;

// //tentar converter se não der, a saida sera e
// int.TryParse(d, out e);