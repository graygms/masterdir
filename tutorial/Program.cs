using System;
namespace tutorial{
    class Program{
        // Here we start??
        static void Main(string[] args){
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            const int born=1962;
            int year=2024;
            int age = year-born;
            string fullName=$"My name is {firstName} {lastName}";  
           Console.WriteLine(fullName);
Console.WriteLine("My age is "+age);
            Console.Write("The master Programmer");
            Console.Write(" The beginning!!");
        }
    }
}
