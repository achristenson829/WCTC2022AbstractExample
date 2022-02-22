using System;

namespace AbstractExample.Models
{
    public class Snake: Animal
    {
        public Snake()
        {
            Name = "Salazar";
        }
        public Snake(string name)
        {
            Name = name;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says Hissssssss");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleeps with both eyes open");
        }
    }
}