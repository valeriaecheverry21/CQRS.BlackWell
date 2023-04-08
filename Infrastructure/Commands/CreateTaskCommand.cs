using CQRS.BlackWell.Application.DTOs;
using MediatR;

namespace CQRS.BlackWell.Infrastructure.Commands
{
    public record CreateTaskCommand(string Title, string Descripcion) 
        : IRequest<TaskItemDto>;
    
}
