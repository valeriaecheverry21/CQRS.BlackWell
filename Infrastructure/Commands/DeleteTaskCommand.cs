using MediatR;

namespace CQRS.BlackWell.Infrastructure.Commands
{
    public record DeleteTaskCommand(int Id) : IRequest<bool>;
    
}
