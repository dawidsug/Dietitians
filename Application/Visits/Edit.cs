using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Visits
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Visit Visit { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var visit = await _context.Visits.FindAsync(request.Visit.Id);
                _mapper.Map(request.Visit, visit);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}