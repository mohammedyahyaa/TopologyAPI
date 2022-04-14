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


        public ICollection<Component> GetComponents()
        {
            return _db.Components.OrderBy(a => a.Type).ToList();
        }

        public Component GetComponent(int ComponentId)
        {
            return _db.Components.FirstOrDefault(a => a.Id == ComponentId);
        }

    }
}
