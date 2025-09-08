using System;
using MyCSharpApp.Test;
namespace MyCSharpApp
{
    class Cat : Animal
    {
        private String name;
        public Cat()
        {
            name = "Cat";
        }
        public String NameCat
        {
            get { return name; }
            set { name = value; }
        }
        public void eat()
        {
            Console.WriteLine($"{name} is eating cat food.");
        }
        public void speak()
        {
            Console.WriteLine($"{name} says Meow!");
        }
    }
}