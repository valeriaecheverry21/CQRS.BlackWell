using CQRS.BlackWell.Application.DTOs;
using MediatR;

namespace CQRS.BlackWell.Infrastructure.Commands
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted) 
        : IRequest<TaskItemDto>;
    

    
}
