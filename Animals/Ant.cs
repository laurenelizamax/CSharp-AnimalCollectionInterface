using System;
namespace AnimalCollectionInterface
{
    public class Ant : IWalking
    {
        public void WalkRun()
        {
            Console.WriteLine("He's a scurries like a mouse.'");
        }
        public int MaxWalkingSpeed { get; set; }
    }

}
