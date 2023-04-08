using CQRS.BlackWell.Application.DTOs;
using MediatR;

namespace CQRS.BlackWell.Infrastructure.Queries
{
    public record GetTaskByIdQuery(int Id) : IRequest<TaskItemDto>;
   
}
