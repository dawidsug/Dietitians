using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Dietitians
{
    public class Details
    {
        public class Query : IRequest<Dietitian>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Dietitian>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Dietitian> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Dietitians.FindAsync(request.Id);
            }
        }
    }
}