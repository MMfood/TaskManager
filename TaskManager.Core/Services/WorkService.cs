using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using TaskManager.Core.Specifications;
using TaskManager.Core.Validations;

namespace TaskManager.Core.Services
{
    public class WorkService : IWorkService
    {
        private readonly IRepository<Work> workRepository;
        
        private readonly IRepository<UserWork> userWorkRepository;

        private readonly IUserService userService;

        public WorkService(IRepository<Work> workRepository, IRepository<UserWork> userWorkRepository, IUserService userService)
        {
            this.workRepository = workRepository;
            this.userWorkRepository = userWorkRepository;
            this.userService = userService;
        }

        public Work CreateWork(string workName, string description, string userId, DateTime? dueDate, int typeWork, ICollection<UserConstruct> selectedUsers, DateTime? nextActionDate = null)
        {
            ValidationWork.ValidateTaskNameIfIsNull(workName);

            Guid workId = Guid.NewGuid();

            var work = new Work
            {
                Id = workId,
                WorkName = workName,
                UserId = Guid.Parse(userId),
                Description = description,
                TypeWorkId = typeWork,
                DueDate = dueDate,
                CreatedOn = DateTime.Now,
            };

            workRepository.Add(work);

            foreach (var selectedUser in selectedUsers)
            {
                if (selectedUser.IsChecked)
                {
                    var userWork = new UserWork
                    {
                        UserId = selectedUser.UserId,
                        Work = null,
                        WorkId = workRepository.Get(workId).Id
                    };
                    userWorkRepository.Add(userWork);
                }
            }

            return work;
        }
        public  Work EditWork(Guid workId, string workName, string description, DateTime? dueDate, int statusWorkId, ICollection<UserConstruct> selectedUsers)
        {
            var work = workRepository
                .List(new WorkGetAllSpecification())
                .SingleOrDefault(a => a.Id.Equals(workId));

            ValidationWork.ValidateTaskNameIfIsNull(workName);

            if ( workRepository
                .List(new WorkGetAllSpecification())
                .Any(n => n.WorkName.Equals(workName.ToLower()) && n.Id != workId))
            {
                throw new ArgumentException($"Задача: {workName} уже существует!");
            }

            work.StatusWorkId = statusWorkId;
            work.WorkName = workName;
            work.Description = description;
            work.DueDate = dueDate;
            workRepository.Update(work);

            return work;
        }


        public List<Work> GetAll()
        {
            var query = workRepository
                .List(new WorkWithCommentSpecification())
                .ToList();

            return query;
        }

        public bool DeleteWork(Guid workId)
        {
            var work = workRepository
                .List(new WorkGetAllSpecification())
                .FirstOrDefault(t => t.Id == workId);

            if (work == null)
            {
                return false;
            }

            workRepository.Delete(work);
            return true;
        }

        public Work FindWorkById(Guid id)
        {
            var work = workRepository
                .List(new WorkWithCommentSpecification())
                .FirstOrDefault(x => x.Id == id);

            return work;
        }

        public List<Work> GetAllWorksForUser(string userId)
        {
            var userworks = userWorkRepository
                .List(new WorksGetAllByUserSpesification(userId));

            var works = workRepository
                .List()
                .Join(userworks,
                x => x.Id,
                y => y.WorkId,
                (x, y) => new Work
                {
                    Id = x.Id,
                    WorkName = x.WorkName,
                    UserId = Guid.Parse(y.UserId),
                    Description = x.Description,
                    TypeWorkId = x.TypeWorkId,
                    DueDate = x.DueDate,
                    CreatedOn = x.CreatedOn
                })
                .ToList();
            return works;
        }
    }
}
