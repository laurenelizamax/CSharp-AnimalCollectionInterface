using System;
using System.Collections.Generic;

namespace AnimalCollectionInterface
{
    public class FlyContainer
    {
        public List<IFlyer> flyingAnimals { get; set; } = new List<IFlyer>();
    }
}