using CQRS.BlackWell.Application.DTOs;
using CQRS.BlackWell.Infrastructure;
using CQRS.BlackWell.Infrastructure.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CQRS.BlackWell.Application.Handlers
{
    public class GetAllTaskHandler : IRequestHandler<GetAllTaskQuery, IEnumerable<TaskItemDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllTaskHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<IEnumerable<TaskItemDto>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _dbContext.TaskItems.ToListAsync(cancellationToken);
            return tasks.Select(task => new TaskItemDto
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted

            });






        }

    }
}
