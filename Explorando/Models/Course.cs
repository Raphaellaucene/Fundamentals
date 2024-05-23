using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Course
    {
        public string Name { get; set;}
        public List<People> Students { get; set; } //Create colletion

        public void AddStudent(People student) { //assign metod.. from "void" (return type)
            Students.Add(student);
        }

        public int GetTotalEnrollStudents() {
            int totalEnroll = Students.Count;
            return totalEnroll;
        }

        public bool RemoveStudent(People student) {
            return Students.Remove(student);
        }

        public void ListStudents() {
            Console.WriteLine($"Students enroll by: {Name}");

            //add prefix befor student name
            for (int count = 0; count < Students.Count; count++) {
                string text = $"n° {count + 1} - {Students[count].FullName}"; //student in process moment
                Console.WriteLine(text);
            }
        }
    }
}