using System;
namespace AnimalCollectionInterface
{
    public class Gerbil : IWalking
    {
        public void WalkRun()
        {
            Console.WriteLine("He likes to run in his wheel");
        }

        public int MaxWalkingSpeed { get; set; }

    }
}