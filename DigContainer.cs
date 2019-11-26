using System;
using System.Collections.Generic;

namespace AnimalCollectionInterface
{
    public class DigContainer
    {
        public List<IDigger> diggingAnimals { get; set; } = new List<IDigger>();
    }
}