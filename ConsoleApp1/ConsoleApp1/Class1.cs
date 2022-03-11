using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public string Name { get; set; }    
        public string Description { get; set; }

        public Class1(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SomeMethod()
        {
            Console.WriteLine("Hello World, modified from main!");
        }
    }
}
