using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Dietitians
{
    public class List
    {
        public class Query : IRequest<List<Dietitian>> { }

        public class Handler : IRequestHandler<Query, List<Dietitian>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Dietitian>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Dietitians.ToListAsync();
            }
        }
    }
}