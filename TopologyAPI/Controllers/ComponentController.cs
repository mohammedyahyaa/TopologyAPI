using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using TopologyAPI.Models.DataRepository;
using TopologyAPI.Repository;

namespace TopologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "TopologyAPI")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentRepository _CompRepo;


        public ComponentController(IComponentRepository CompRepo)
        {
            _CompRepo = CompRepo;


        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Component>))]
        public IActionResult GetComponents()
        {
            var objList = _CompRepo.GetComponents();
       
            return Ok(objList);
        }

        [HttpGet("{Id:int}", Name = "TopologyAPI")]
        [ProducesResponseType(200, Type = typeof(Component))]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetComponent(int componentId)
        {
            var obj = _CompRepo.GetComponent(componentId);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);

        }




    }

}