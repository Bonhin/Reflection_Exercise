using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExercise
{
    public class Student
    {
        public string Name { get ; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {Name} - University: {University} - Roll Number: {RollNumber}");
        }
    }
}
