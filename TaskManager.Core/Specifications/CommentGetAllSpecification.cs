using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class CommentGetAllSpecification : ISpecification<Comment>
    {

        public IList<string> Includes => new List<string>
        { };

        public CommentGetAllSpecification()
        { }

        public IQueryable<Comment> Apply(IQueryable<Comment> query)
        {
            return query;
        }
    }
}