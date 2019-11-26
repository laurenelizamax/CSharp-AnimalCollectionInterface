using System;
namespace AnimalCollectionInterface
{
    public class Terrapin : IWalking, ISwimming
    {
        public void WalkRun()
        {
            Console.WriteLine("He's a slow little turtle");
        }
        public int MaxWalkingSpeed { get; set; }

        public void Swim()
        {
            Console.WriteLine("He's a good swimmer");
        }
        public int MaximumDepth { get; set; }

    }
}