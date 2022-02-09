using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class UsersGetAllForWorkSpecification : ISpecification<User>
    {
        public IList<string> Includes => new List<string>
        {
            $"{nameof(User.UserWorks)}"
        };

        public UsersGetAllForWorkSpecification()
        { }

        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query;
        }
    }
}
