using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milgot.API.Models;
using Milgot.Common.DTOs;
using Milgot.Services.Interfaces;

namespace Milgot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildrenService _childService;

        public ChildrenController(IChildrenService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<List<ChildrenDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<ChildDTO>> Get(int id)
        //{
        //    return await _childService.GetByIdAsync(id);
        //}

        [HttpGet("{childId}")]
        public async Task<ActionResult<ChildrenDTO>> Get(int childId)
        {
            return await _childService.GetByIdAsync(childId);
        }

        [HttpPost]
        public async Task<ActionResult<ChildrenDTO>> Post([FromBody] ChildrenModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.AddAsync(new ChildrenDTO { Name = model.Name, Tz = model.Tz, BirthDate = model.BirthDate, ParentId = model.ParentId });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ChildrenDTO>> Put([FromBody] ChildrenModel model)//insert-add
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.UpdateAsync(new ChildrenDTO {Name= model.Name,Tz= model.Tz,BirthDate= model.BirthDate,ParentId= model.ParentId });
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int childId)
        {
            await _childService.DeleteAsync(childId);
            return NoContent();
        }
    }
}
