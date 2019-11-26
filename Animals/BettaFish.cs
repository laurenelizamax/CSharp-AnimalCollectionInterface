using System;
namespace AnimalCollectionInterface
{
    public class BettaFish : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("He's a good swimmer");
        }
        public int MaximumDepth { get; set; }

    }
}