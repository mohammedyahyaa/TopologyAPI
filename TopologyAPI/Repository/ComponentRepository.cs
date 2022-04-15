using System.Collections.Generic;
using System.Linq;
using TopologyAPI.Data;
using TopologyAPI.Models;
using TopologyAPI.Models.DataRepository;

namespace TopologyAPI.Repository
{
    public class ComponentRepository : IComponentRepository
    {

        private readonly ApplicationDbContext _db;

        public ComponentRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public ICollection<RootComponent> GetComponents()
        {
            return _db.Components.OrderBy(a => a.Id).ToList();
        }

        public RootComponent GetComponent(int ComponentId)
        {
            return _db.Components.FirstOrDefault(a => a.Id == ComponentId);
        }

        public bool ComponentExist(string name)
        {
            bool value = _db.Components.Any(a => a.Type.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool ComponentExist(int id)
        {
            return _db.Components.Any(a => a.Id == id);
        }

        public bool CreateComponent(RootComponent component)
        {
            _db.Components.Add(component);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateComponent(RootComponent component)
        {
            _db.Components.Update(component);
            return Save();
        }

        public bool DeleteComponent(RootComponent Component)
        {
            _db.Components.Remove(Component);
            return Save();
        }
    }
}
