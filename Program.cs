// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Spg.BasicDemo.Model;
using System.Reflection;

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

