using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Dietitians
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Dietitian Dietitian { get; set; }
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
                var dietitian = await _context.Dietitians.FindAsync(request.Dietitian.Id);
                _mapper.Map(request.Dietitian, dietitian);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}