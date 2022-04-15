using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using TopologyAPI.Models;
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
        [ProducesResponseType(200, Type = typeof(List<RootComponent>))]
        public IActionResult GetComponents()
        {
            var objList = _CompRepo.GetComponents();
       
            return Ok(objList);
        }

        [HttpGet("{Id:int}", Name = "TopologyAPI")]
        [ProducesResponseType(200, Type = typeof(RootComponent))]
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

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(RootComponent))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateComponent([FromBody] RootComponent componentObj )
        {
            if (componentObj == null)
            {
                return BadRequest(ModelState);
            }
            if (_CompRepo.ComponentExist(componentObj.Id))
            {
                ModelState.AddModelError("", "Component Exists!");
                return StatusCode(404, ModelState);
            }
           // var nationalParkObj = _mapper.Map<NationalPark>(nationalParkDto);
            if (!_CompRepo.CreateComponent(componentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {componentObj.Id}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetComponent", new { ComponentId = componentObj.Id }, componentObj);
        }


        [HttpPatch("{Id:int}", Name = "UpdateComponent")]
        [ProducesResponseType(204)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateComponent(int ComponentId, [FromBody] RootComponent componentObj)
        {
            if (componentObj == null || ComponentId != componentObj.Id)
            {
                return BadRequest(ModelState);
            }

            //var nationalParkObj = _mapper.Map<NationalPark>(nationalParkDto);
            if (!_CompRepo.UpdateComponent(componentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when updating the record {componentObj.Type}");
                return StatusCode(500, ModelState);
            }

            return NoContent();

        }


        [HttpDelete("{Id:int}", Name = "DeleteComponent")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteNationalPark(int ComponentId)
        {
            if (!_CompRepo.ComponentExist(ComponentId))
            {
                return NotFound();
            }

            var ComponentObj = _CompRepo.GetComponent(ComponentId);
            if (!_CompRepo.DeleteComponent(ComponentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {ComponentObj.Type}");
                return StatusCode(500, ModelState);
            }

            return NoContent();

        }







    }

}