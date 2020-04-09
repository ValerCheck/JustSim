namespace JustSim.Contracts.Resources
{
    public interface IResource
    {
        double TotalCapacity { get; }
        double AvailableCapacity { get; }
        void Allocate(double requestedCapacity);
        bool TryAllocate(double requestedCapacity);
    }
}
