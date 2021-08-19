using System;
using System.Collections.Generic;
using Application.Dietitians;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("API/[controller]/[action]")]
    public class DietitiansController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Dietitian>>> GetDietitians()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dietitian>> GetDietitian(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateDietitian(Dietitian dietitian)
        {
            return Ok(await Mediator.Send(new Create.Command{Dietitian = dietitian}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditDietitian(Guid id, Dietitian dietitian)
        {
            dietitian.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Dietitian = dietitian}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDietitian(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}