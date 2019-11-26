using System;
using System.Collections.Generic;

namespace AnimalCollectionInterface
{
    public class WalkContainer
    {
        public List<IWalking> walkingAnimals { get; set; } = new List<IWalking>();
    }
}