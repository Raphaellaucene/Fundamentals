using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class People
    {   
        // empt constructor to without required params
        public People(){

        }

        //constructor with same name of class
        public People(string name, string lastName) {
            Name = name;
            LastName = lastName;
        }

        //deconstructor inverting
        public void Deconstruct(out string name, out string lastName) {

            name = Name;
            lastName = LastName;
        }

        //create encapsuling fields
        private string _name;

        private int _age;

        public string Name {
            // get {
            //     return _name.ToUpper();
            // }

            //using body expressions
            get => _name.ToUpper();

            set {
                if (value == ""){ //arg than receive a name
                    throw new ArgumentException("Name can not be empty"); //create exception
                }
                _name = value;
            }
        }

        public string LastName { get; set; } //get and set propriety
        public string FullName => $"{Name} {LastName}".ToUpper(); //just get to concatenate

        public int Age {
            get => _age;
            
            set {
                if(value < 0) {
                    throw new ArgumentException("Age can not be less than zero!");
                }
                _age = value;
            }
        }

        public void ShowPeople() {
            Console.WriteLine($"Name: {FullName}, Idade: {Age}");
        }
    }
}