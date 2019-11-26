using System;
namespace AnimalCollectionInterface
{
    public class Finch : IFlyer
    {
        public void Fly()
        {
            Console.WriteLine("He soars with the Eagles");
        }
        public int MaxFlyingSpeed { get; set; }
    }
}