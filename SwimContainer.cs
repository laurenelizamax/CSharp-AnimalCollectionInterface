using System;
using System.Collections.Generic;

namespace AnimalCollectionInterface
{
    public class SwimContainer
    {
        public List<ISwimming> swimmingAnimals { get; set; } = new List<ISwimming>();
    }
}