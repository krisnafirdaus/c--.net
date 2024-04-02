using System;
namespace krisna_test_3
{

    public class Student
    {
        // Properti untuk menyimpan nama siswa
        public string Name { get; set; }

        // Konstruktor yang menerima nama siswa
        public Student(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var name = true;
            //if (name)
            //{
            //    Console.WriteLine("Hallo");
            //}

            //switch (name)
            //{
            //    case true:
            //        Console.WriteLine("Hallo");
            //        break;
            //    default:
            //        Console.WriteLine("Hello World!");
            //        break;
            //}

            //while ()
            //{
            //    Console.WriteLine("Hello World!");
            //}

            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //var names = new[] { "name", "test", "andi" };

            //foreach (var andi in names)
            //{
            //    Console.WriteLine(andi);
            //}

            //List<Student> list = new List<Student>();
            //list.Add(new Student("Bob"));
            //list.Add(new Student("Joe"));
            //Student joe = list[0];

            //Console.WriteLine(joe.Name);

            //Laptop laptop1 = new Laptop();
            //laptop1.Brand = "Dell";
            //laptop1.Model = "Inspiration 14R";
            //laptop1.LaptopDetails();
            //Console.WriteLine("\nPress Enter to Exit...");
            //Console.ReadLine();

            Details d = new Details();
            d.Name = "Krisna";
            d.Age = 12;
            d.GetUserDetails("Indonesia");
            d.getAge();
            Console.WriteLine("\nPress Enter to Exit...");
            Console.ReadLine();
        }
    }
}