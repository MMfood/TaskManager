using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace TaskManager.Core.Interfaces
{
    public interface IUserService
    {
        List<UserConstruct> GetAllUsers();
        List<UserConstruct> GetSelectedUsers(Guid workid);
        List<UserConstruct> GetAllUsersForWork(Guid workid);
    }
}
