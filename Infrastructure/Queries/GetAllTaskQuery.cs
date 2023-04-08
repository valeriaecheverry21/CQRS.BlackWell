using CQRS.BlackWell.Application.DTOs;
using MediatR;

namespace CQRS.BlackWell.Infrastructure.Queries
{
    public record GetAllTaskQuery : IRequest<IEnumerable<TaskItemDto>>;
    
}
