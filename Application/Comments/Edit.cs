using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Comments
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Comment Comment { get; set; }
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
                var comment = await _context.Comments.FindAsync(request.Comment.Id);
                _mapper.Map(request.Comment, comment);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}