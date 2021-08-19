using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Visits;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("API/[controller]/[action]")]
    public class VisitsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Visit>>> GetVisits()
        {
            return await Mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Visit>> GetVisit(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateVisit(Visit visit)
        {
            return Ok(await Mediator.Send(new Create.Command{Visit = visit}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditVisit(Guid id, Visit visit)
        {
            visit.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Visit = visit}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisit(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}