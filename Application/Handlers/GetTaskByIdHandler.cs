﻿using CQRS.BlackWell.Application.DTOs;
using CQRS.BlackWell.Infrastructure;
using CQRS.BlackWell.Infrastructure.Queries;
using MediatR;

namespace CQRS.BlackWell.Application.Handlers
{
    public class GetTaskByIdHandler : IRequestHandler<GetTaskByIdQuery, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTaskByIdHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<TaskItemDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItems.FindAsync
              (new object[] { request.Id }, cancellationToken);

            if (taskItem == null) { return null; }
            return new TaskItemDto
            {
                Id = taskItem.Id,
                Title = taskItem.Title,
                Description = taskItem.Description,
                IsCompleted = taskItem.IsCompleted

            };
        }
    }
}
