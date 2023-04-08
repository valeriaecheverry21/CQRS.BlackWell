﻿using CQRS.BlackWell.Application.DTOs;
using CQRS.BlackWell.Domain;
using CQRS.BlackWell.Infrastructure;
using CQRS.BlackWell.Infrastructure.Commands;
using MediatR;

namespace CQRS.BlackWell.Application.Handlers
{
    public class CreateTaskHandler :
        IRequestHandler<CreateTaskCommand, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateTaskHandler(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        
        }
        public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = new TaskItem
            { Title = request.Title,
                Description = request.Descripcion
            };

            _dbContext.TaskItems.Add(taskItem);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new TaskItemDto 
            { 
              Id = taskItem.Id,
              Title = request.Title,
              Description = taskItem.Description,
              IsCompleted = taskItem.IsCompleted
            };
        }
    }


}
