using TaskManager.Core.Entities;
using TaskManager.Web.Interfaces;
using TaskManager.Web.Models;

using System.Collections.Generic;

namespace TaskManager.Web.Services
{
    public class WorkMapper : IMapper<WorkViewModel, Work>
    {
        public WorkViewModel Map(Work entity)
        {
            return new WorkViewModel
            {
                Id = entity.Id,
                WorkName = entity.WorkName,
                Description = entity.Description,
                DueTime = entity.DueDate,
                StatusWork = entity.StatusWorkId,
                TypeWork = entity.TypeWorkId,
                NextActionDate = entity.NextActionDate,
                CreatedOn = entity.CreatedOn,
                AllUsers = new List<UserConstruct>()
            };
        }
    }
}
