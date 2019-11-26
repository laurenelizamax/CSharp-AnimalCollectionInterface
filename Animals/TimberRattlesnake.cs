using System;
namespace AnimalCollectionInterface
{
    public class TimberRattleSnake : IWalking
    {
        public void WalkRun()
        {
            Console.WriteLine("He slithers in the grass.");
        }
        public int MaxWalkingSpeed { get; set; }
    }
}