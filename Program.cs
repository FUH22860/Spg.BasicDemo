// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Spg.BasicDemo.Model;
using System.Reflection;

internal class Program {
    private static void Main(string[] args) {
        string s = "Hello, world!";

        Console.WriteLine(s);

        
        Student student = new Student();
        student.FirstName = "Martin";
        student.LastName = "Schrutek";
        student.Id = 1;

        student.Id.ToString();

        bool isEqual = student.Equals(new Student());


        // Reflections
        PropertyInfo[] properties = student.GetType().GetProperties();

        foreach (PropertyInfo property in properties) {
            Console.Out.WriteLine(property.Name);
        }

        int? e = null;
        int? f = null;
        int g = 0;

        Console.WriteLine(e ?? f ?? 5);
        g = e ?? 0;

        Console.WriteLine(g);

        //string s3 = null;
        string s3 = "Goodbye, world!";
        Console.WriteLine($"Length = {s3?.Length ?? 0}");

        bool y = 5 == 5 ? true : false;
        Console.WriteLine(y);
    }
}