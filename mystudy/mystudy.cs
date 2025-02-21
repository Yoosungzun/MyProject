using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string? Name;
}

class Program
{
    static void Main(string[] args)
    {
        var p = new Person {Name = "Charlie"};
        Console.WriteLine(p.Name);
    }
}
