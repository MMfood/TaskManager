using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class WorksGetAllByUserSpesification : ISpecification<UserWork>
    {
        private string userId;
        public IList<string> Includes => new List<string>
        {
            $"{nameof(UserWork.User)}"
        };

        public WorksGetAllByUserSpesification(string userId)
        {
            this.userId = userId;
        }

        public IQueryable<UserWork> Apply(IQueryable<UserWork> query)
        {
            return query.Where(x => x.UserId == userId);
        }
    }
}
