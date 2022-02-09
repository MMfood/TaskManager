using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class UsersGetSelected : ISpecification<UserWork>
    {
        private Guid workId;
        public IList<string> Includes => new List<string>
        {
            $"{nameof(UserWork.User)}"
        };

        public UsersGetSelected(Guid workId)
        {
            this.workId = workId;
        }

        public IQueryable<UserWork> Apply(IQueryable<UserWork> query)
        {
            return query.Where(x => x.WorkId == workId);
        }
    }
}
