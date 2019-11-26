using System;
namespace AnimalCollectionInterface
{
    public class Parakeet : IFlyer
    {
        public void Fly()
        {
            Console.WriteLine("He flies around the house");
        }
        public int MaxFlyingSpeed { get; set; }

    }
}