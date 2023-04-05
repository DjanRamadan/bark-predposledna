using System;
using System.Collections.Generic;
using System.Linq; using System.Text;
using System.Threading.Tasks;  
namespace TestZad 
{     internal class TestZad     
    {         static void Main()         
        {             
            Dog myDog = new Dog();             
            Console.Write("Enter the dog's name: ");             
            var namedog = Console.ReadLine();            
            myDog.Name = namedog;            
            Console.Write($"Enter {namedog}'s age: ");             
            myDog.Age = int.Parse(Console.ReadLine());             
            Console.Write($"Enter the amount of times {namedog} barks: ");             
            myDog.Bark(int.Parse(Console.ReadLine()));
        }     
    }
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Dog {Name} barks!");
            }
        }
    }
}