using System;
namespace AnimalCollectionInterface
{
    public class Mouse : IWalking
    {
        public void WalkRun()
        {
            Console.WriteLine("He scuttles like a mouse in the house.");
        }
        public int MaxWalkingSpeed { get; set; }

    }
}