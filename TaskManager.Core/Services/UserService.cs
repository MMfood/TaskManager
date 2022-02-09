using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using TaskManager.Core.Specifications;

namespace TaskManager.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<UserWork> userWorkRepository;

        public UserService(IRepository<User> userRepository, IRepository<UserWork> userWorkRepository)
        {
            this.userRepository = userRepository;
            this.userWorkRepository = userWorkRepository;
        }


        public List<UserConstruct> GetAllUsers()
        {
     
           return userRepository.List(new UsersGetAllSpecification()).Select(x => new UserConstruct { UserId = x.Id, UserName = x.UserName }).ToList();
        }

        public List<UserConstruct> GetAllUsersForWork(Guid workId)
        {
            return userRepository.List(new UsersGetAllForWorkSpecification())
                .Select(x => new UserConstruct { UserId = x.Id, UserName = x.UserName, IsChecked = x.UserWorks.Any(y => y.WorkId == workId && y.UserId == x.Id) }).ToList();
        }

        public List<UserConstruct> GetSelectedUsers(Guid workId)
        {
            return userWorkRepository.List(new UsersGetSelected(workId))
                .Select(x => new UserConstruct { UserId = x.User.Id, IsChecked = true, UserName = x.User.UserName })
                .ToList();

        }
}
}
