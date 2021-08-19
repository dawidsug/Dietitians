using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Comments;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("API/[controller]/[action]")]
    public class CommentsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Comment>>> GetComments()
        {
            return await Mediator.Send(new List.Query());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetComment(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            return Ok(await Mediator.Send(new Create.Command{Comment = comment}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditComment(Guid id, Comment comment)
        {
            comment.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Comment = comment}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}