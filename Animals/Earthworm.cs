using System;
namespace AnimalCollectionInterface
{
    public class Earthworm : IWalking, IDigger
    {
        public int MaxWalkingSpeed { get; set; }
        public void WalkRun()
        {
            Console.WriteLine("He slithers on the ground");
        }
        public void Dig()
        {
            Console.WriteLine("He digs underground when it rains");
        }
        public int BurrowDepth { get; set; }
    }
}