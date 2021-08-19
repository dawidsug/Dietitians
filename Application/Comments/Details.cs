using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Comments
{
    public class Details
    {
        public class Query : IRequest<Comment>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Comment>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Comment> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Comments.FindAsync(request.Id);
            }
        }
    }
}