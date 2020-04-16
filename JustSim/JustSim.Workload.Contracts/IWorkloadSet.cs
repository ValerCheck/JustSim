using System.Collections.Generic;

namespace JustSim.Workload.Contracts
{
    public interface IWorkloadSet : IColumnContainer
    {
        IEnumerable<IWorkloadRecord> Records { get; }
    }
}
