using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Comments
{
    public class List
    {
        public class Query : IRequest<List<Comment>> {}

        public class Handler : IRequestHandler<Query, List<Comment>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Comment>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Comments.ToListAsync();
            }
        }
    }
}