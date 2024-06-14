using System.Globalization;
using System.Net.Http.Headers;
using Models;
//using System.Reflection.Metadata;

//-- Serialization --
using Newtonsoft.Json;

//object
//Sale v1 = new Sale(1, "Office Supplies", 25.00M);

//collection
List<Sale> saleList = new List<Sale>();

Sale v1 = new Sale(1, "Office Supplies", 30.0M);
Sale v2 = new Sale(2, "Office 365 E5", 110.0M);

saleList.Add(v1);
saleList.Add(v2);

//json convert
//string serialized = JsonConvert.SerializeObject(v1);
//string serialized = JsonConvert.SerializeObject(v1, Formatting.Indented); //with line break
string serialized = JsonConvert.SerializeObject(saleList, Formatting.Indented); //serialize collection

Console.WriteLine(serialized);

//create sales json file
File.WriteAllText("Files/sales.json", serialized);




//-- Ternary If --

//int number = 15;
//bool isEven = false;

//isEven = number % 2 == 0;

//ternary if
//Console.WriteLine($"The number {number} is " + (isEven ? "Even" : "odd"));

//-- Deconstructor --
// People p1 = new People("Pumita", "Rodrigo");

//split in two parts
// (string name, string lastName) = p1;

// Console.WriteLine($"{name} {lastName}");

//-- Tuplas --

// ReadFile file = new ReadFile();

//var using for assume automatically the data type
// var (sucess, linesFiles, totalLines) = file.ReadArq("Files/fileRead.txt");

//Descarted using underscore
//var (sucess, linesFiles, _) = file.ReadArq("Files/fileRead.txt");

// if (sucess) {

//     Console.WriteLine("Number of lines in teh file:" + totalLines);

//     foreach(string line in linesFiles) {
//         Console.WriteLine(line);
//     }
// } else {

//     Console.WriteLine("It wasnt possible to read the file..");
// }

//declare data types and your values and rename itens
// (int Id, string Name, string LastName, decimal Height) tupla = (1, "Leo", "Jardan", 1.90M);

//passing type of data, but we cant rename the itens
//ValueTuple<int, string, string, decimal> anotherExTupla = (1, "Leo", "Jardan", 1.90M);

//using Create we dont pass the type, it already identifies
//var anotherExTuplaCreate = Tuple.Create(1, "Leo", "Jardan", 1.80M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Hight: {tupla.Item4}");

//-- Dictionary --

//dictionary is a key-value colection using to storage
//unique values without an specific order
//It will ensure that your elements are unique based on the key

//passing key and data types
//Dictionary<string, string> states = new Dictionary<string, string>();

//states.Add("SP", "São Paulo");
//states.Add("MG", "Minas Gerais");
//states.Add("PR", "Paraná");

//foreach (KeyValuePair <string, string> item in states) //keyValuePair represente the dictionary
//but you can use var instead keyvaluepair and he recognize the data type
// foreach (var item in states)
// {
//     //representing key = MG and value = Minas Gerais
//     Console.WriteLine($"Key: {item.Key}, value: {item.Value}");
// }

// states.Remove("MG"); //removing key (u cannot change the key, just remove)

// states["SP"] = "San Paul"; //update value (always by key)

// string key = "PR";
// Console.WriteLine($"Checking the element: {key}");

//checking if in states contain key
// if (states.ContainsKey(key)) {
//     Console.WriteLine($"Existing value: {key}");
// }
// else {
//     Console.WriteLine($"Value not exist.. There is safe to add the key: {key}");
// }

//get value
//Console.WriteLine(states["PR"]);

//Colections - stack
//collection is LIFO, Last in First Out
// Stack<int> stack = new Stack<int>();

//insert object at top of the stack
// stack.Push(32);
// stack.Push(2);
// stack.Push(3);
// stack.Push(5);

// foreach(int item in stack) {
//     Console.WriteLine(item);
// }

//removing the last element insert
// Console.WriteLine($"Removing the top element: {stack.Pop()}");

//queue integer constructor
//queue is FIFO
// Queue<int> queue = new Queue<int>();

//fit an object in the end of line
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.Enqueue(5);
// queue.Enqueue(90);

// foreach (int item in queue)
// {
//     Console.WriteLine(item);
// }

//always remove the first element
// Console.WriteLine($"Removendo o elemento: {queue.Dequeue()}");

// foreach (var item in queue)
// {
//     Console.WriteLine(item);
// }

//new ExExeption().Method1();

//Not Generic exeption
// try
// {
//     //each line can return in a string
//     string[] lines = File.ReadAllLines("Files/filedRead.txt"); //using class file to read a file

//     foreach(string line in lines) {
//         Console.WriteLine(line);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Occurred an error at read de file.. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Occurred an error at read de file.. {ex.Message}");
// }
// //Generic exeption
// catch (Exception ex)
// {
//     Console.WriteLine($"A Generic exception occurred.. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("end of line...");
// }


//structure datetime
//DateTime data = DateTime.Now; //get time from local settings

//Console.WriteLine(data.ToString("dd/MM/yy HH:mm")); //format

//Console.WriteLine(data.ToShortTimeString()); //HH:mm

//convert text to DateTime
//DateTime data = DateTime.Parse("17/02/24 08:55");

// string dateString = "2023-04-03 18:00";

// //try convert using culture and style and if not or convert out in var date return boolean
// bool sucess = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

// if (sucess) {
//     Console.WriteLine($"Good! Convert worked.. Date: {date}");
// }
// else {
//     Console.WriteLine($"{dateString} is not a valid date..");
// }

//set system culture
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// //curency
// decimal currency = 82.40M;

// //changing specific culture
// Console.WriteLine(currency.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine($"{currency:C}"); // means formating and C = currency

// Console.WriteLine(currency.ToString("C2")); //format with two decimal numbers

// Console.WriteLine(currency.ToString("N2")); //format in number with two decimal numbers

// double percent = .3421;

// Console.WriteLine(percent.ToString("P")); //print 34,21%

// int number = 123456;
// Console.WriteLine(number.ToString("##-##-##")); //print 12-34-56

// People p1 = new People(name: "Leo", lastName: "Batista");
// // p1.Name = "Leo";
// // p1.LastName = "Batista";

// People p2 = new People("Duda", "Snow");
// // p2.Name = "Duda";
// // p2.LastName = "Snow";

// //instancing class
// Course engCourse = new Course();
// engCourse.Name = "English";
// engCourse.Students = new List<People>();

// engCourse.AddStudent(p1);
// engCourse.AddStudent(p2);
// engCourse.ListStudents();

// People p1 = new People();
// p1.Name = "Carlos";
// p1.LastName = "Silva";
// p1.Age = 20;
// p1.Show();

