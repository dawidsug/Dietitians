using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Comments
{
    public class Create
    {
        public class Command : IRequest
        {
            public Comment Comment { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Comments.Add(request.Comment);

                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}