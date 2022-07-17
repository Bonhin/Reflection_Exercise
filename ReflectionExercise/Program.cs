using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ReflectionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DisplayPublicProperties();

            CreateInstance();
        }

        static void DisplayPublicProperties()
        {
            foreach (var propertyInfo in typeof(Student).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                Console.WriteLine($"A propriedade {propertyInfo.Name} presente na classe é Publica");
            }
            Console.WriteLine();
        }

        static void CreateInstance()
        {
            
            var students = (Student)Activator.CreateInstance(typeof(Student));

            var properties = students.GetType().GetRuntimeProperties();

            foreach (var property in properties)
            {
                
                Console.Write($"Set the {property.Name}:");

                if (property.PropertyType == typeof(System.String))
                {
                    property.SetValue(students, Console.ReadLine());
                }
                if (property.PropertyType == typeof(System.Int32))
                {
                    property.SetValue(students, int.Parse(Console.ReadLine()));
                }                

            }

            var studentType = students.GetType();

            var studentMethod = studentType.GetMethod("DisplayInfo");

            studentMethod.Invoke(students, null);

        }

    }
}

