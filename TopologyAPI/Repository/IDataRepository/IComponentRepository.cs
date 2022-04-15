using System.Collections.Generic;

namespace TopologyAPI.Models.DataRepository
{
    public interface IComponentRepository
    {
        ICollection<RootComponent> GetComponents();
        RootComponent GetComponent(int nationalParkId);

        bool ComponentExist(string name);
        bool ComponentExist(int id);
        bool CreateComponent(RootComponent component);

        bool UpdateComponent(RootComponent component);

        bool DeleteComponent(RootComponent Component);
        bool Save();
    }
}
