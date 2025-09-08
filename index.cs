using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Console;
namespace MyCSharpApp
{
    class Index
    {
        public static void Main(String[] args)
        {
            Dog dog = new Dog();
            dog.eat();
            dog.speak();
            Dog muile = new Dog();
            muile.NameDog = "Muile";
            muile.eat();
            muile.speak();
            Cat cat = new Cat();
            cat.eat();
            cat.speak();
            ReadLine();

        }
    }
}