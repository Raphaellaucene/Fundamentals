using System.Globalization;
using System.Reflection.Metadata;
using Explorando.Models;

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

//Colections - stack
//collection is LIFO, Last in First Out

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

