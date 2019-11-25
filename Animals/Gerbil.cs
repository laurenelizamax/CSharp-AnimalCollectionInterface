using System;
namespace interfacePractices
{
    public class Gerbil : IWalking
    {
        public void Run()
        {
            Console.WriteLine("He likes to run in his wheel");
        }
        public void Walk()
        {
            Console.WriteLine("He walks around his cage.");

        }

    }
}