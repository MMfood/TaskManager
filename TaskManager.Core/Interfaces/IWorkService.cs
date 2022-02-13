using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Core.Entities;

namespace TaskManager.Core.Interfaces
{
    public interface IWorkService
    {
        Work CreateWork(string workName, string description, string userId, DateTime? dueDate, int typeWork, ICollection<UserConstruct> selectedUsers, DateTime? nextActionDate = null);
        List<Work> GetAll();
        bool DeleteWork(Guid workId);
        public Work FindWorkById(Guid id);
        Work EditWork(Guid workId, string workName, string description, DateTime? dueDate, int statusWorkId, ICollection<UserConstruct> selectedUsers);

        List<Work> GetAllWorksForUser(string userId);
    }
}
