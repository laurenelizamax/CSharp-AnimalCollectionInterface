using System;
namespace AnimalCollectionInterface
{
    public class CopperheadSnake : IWalking
    {
        public void WalkRun()
        {
            Console.WriteLine("He slithers after his prey");
        }
        public int MaxWalkingSpeed { get; set; }

    }
}