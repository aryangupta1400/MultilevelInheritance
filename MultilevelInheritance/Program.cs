
// 8) Create one example for Multilevel inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            sparrow.Display();

            Penguin penguin = new Penguin();
            penguin.Display();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Name(string name)
        {
            Console.WriteLine("This is a " + name);
        }
    }

    class Birds : Animal
    {
        public void CanFly(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Yes..! It can fly\n");
            }
            else
            {
                Console.WriteLine("Oh..! It cannot fly\n");
            }
        }
    }

    class Sparrow : Birds
    {
        public void Display()
        {
            Birds birds = new Birds();
            birds.Name("Sparrow");
            birds.CanFly(true);
        }
    }

    class Penguin : Birds
    {
        public void Display()
        {
            Birds birds = new Birds();
            birds.Name("Penguin");
            birds.CanFly(false);
        }
    }
}
