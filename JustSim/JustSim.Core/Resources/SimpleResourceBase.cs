using JustSim.Contracts.Resources;
using System;

namespace JustSim.Core.Resources
{
    internal abstract class SimpleResourceBase : IResource
    {
        public SimpleResourceBase(double totalCapacity)
        {
            TotalCapacity = AvailableCapacity = totalCapacity;
        }

        public double TotalCapacity { get; }

        public double AvailableCapacity { get; private set; }

        public void Allocate(double requestedCapacity)
        {
            if (AvailableCapacity >= requestedCapacity)
            {
                AvailableCapacity -= requestedCapacity;
            }
            else
                throw new InvalidOperationException($"Not enough resource for {GetType().Name}");
        }

        public void Deallocate(double deallocateCapacity)
        {
            var newAvailableCapacity = AvailableCapacity + deallocateCapacity;
            AvailableCapacity = Math.Min(newAvailableCapacity, TotalCapacity);
        }

        public bool TryAllocate(double requestedCapacity)
        {
            try
            {
                Allocate(requestedCapacity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
