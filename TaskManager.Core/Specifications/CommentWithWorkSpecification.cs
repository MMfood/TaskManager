using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class CommentWithWorkSpecification : ISpecification<Comment>
    {

        public IList<string> Includes => new List<string>
        {
            $"{nameof(Comment.Work)}"
        };

        public CommentWithWorkSpecification()
        { }

        public IQueryable<Comment> Apply(IQueryable<Comment> query)
        {
            return query;
        }
    }
}