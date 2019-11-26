namespace AnimalCollectionInterface
{
    public interface IWalking
    {
        int MaxWalkingSpeed { get; set; }
        void WalkRun();
    }
}