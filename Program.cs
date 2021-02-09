using System;
using en = EaterNamespace;
using mn=MyNamespace;

namespace MyNamespace
{
    public class AnotherProgram
    {
        public static void PrintText()
        {
            Console.WriteLine("Hello Earth!");
        }
    }
}
namespace EaterNamespace
{
    public class Eater
    {
        public static void Eat()
        {
            Console.WriteLine("Munch Munch Munch");
        }
    }
}


namespace AnotherProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            mn.AnotherProgram.PrintText();
            en.Eater.Eat();
        }
    }
}
