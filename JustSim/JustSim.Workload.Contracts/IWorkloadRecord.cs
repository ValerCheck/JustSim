namespace JustSim.Workload.Contracts
{
    public interface IWorkloadRecord : IColumnContainer
    {
        object GetVaue(string key);
        object GetValue(int index);
    }
}
