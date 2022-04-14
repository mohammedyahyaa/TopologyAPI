using System.Collections.Generic;

namespace TopologyAPI.Models.DataRepository
{
    public interface IComponentRepository
    {
        ICollection<Component> GetComponents();
        Component GetComponent(int nationalParkId);

        //bool NationalParkExists(string name);
        //bool NationalParkExists(int id);
        //bool CreateNationalPark(NationalPark nationalPark);
        //bool UpdateNationalPark(NationalPark nationalPark);
        //bool DeleteNationalPark(NationalPark nationalPark);
        //bool Save();
    }
}
