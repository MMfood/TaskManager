using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class CommentGetAllByWorkIdSpecification : ISpecification<Comment>
    {
        private Guid workId;


        public IList<string> Includes => new List<string>
        {
            $"{nameof(Comment.User)}"
        };

        public CommentGetAllByWorkIdSpecification(Guid workId)
        {
            this.workId = workId;
        }

        public IQueryable<Comment> Apply(IQueryable<Comment> query)
        {
            return query.Where(x => x.WorkId == workId);
        }
    }
}