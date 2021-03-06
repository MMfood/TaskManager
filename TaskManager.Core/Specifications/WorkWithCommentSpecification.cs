using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class WorkWithCommentSpecification : ISpecification<Work>
    {

        public IList<string> Includes => new List<string>
        {
            $"{nameof(Work.Comments)}"
        };

        public WorkWithCommentSpecification()
        { }

        public IQueryable<Work> Apply(IQueryable<Work> query)
        {
            return query;
        }
    }
}
