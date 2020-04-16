namespace JustSim.Workload.Contracts
{
    public interface IWorkloadSetBuilder
    {
        IWorkloadSetBuilder ApplyFilter();
        IWorkloadSet Build();
    }
}
