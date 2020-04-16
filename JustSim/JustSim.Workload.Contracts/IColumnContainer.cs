using System.Collections.Generic;

namespace JustSim.Workload.Contracts
{
    public interface IColumnContainer
    { 
        IDictionary<int, string> ColumnNames { get; }
    }
}
