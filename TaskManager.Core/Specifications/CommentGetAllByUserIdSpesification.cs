using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class CommentGetAllByUserIdSpesification : ISpecification<Comment>
    {
        private string userId;


        public IList<string> Includes => new List<string>
        {
            $"{nameof(Comment.User)}"
        };

        public CommentGetAllByUserIdSpesification(string userId)
        {
            this.userId = userId;
        }

        public IQueryable<Comment> Apply(IQueryable<Comment> query)
        {
            return query.Where(x => x.UserId == userId);
        }
    }
}