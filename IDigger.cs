namespace AnimalCollectionInterface
{
    public interface IDigger
    {
        void Dig();

        int BurrowDepth { get; set; }
    }
}