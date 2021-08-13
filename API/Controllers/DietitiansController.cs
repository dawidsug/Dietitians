using System;
using System.Collections.Generic;
using Application.Dietitians;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DietitiansController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Dietitian>>> GetDietitians()
        {
            return await Mediator.Send(new List.Query());
        }
    }
}