using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System;

namespace TaskManager.Core.Specifications
{
    internal class CommentSearchAllSpecification : ISpecification<Comment>
    {
        private int workId;
        private string text;

        public IList<string> Includes => new List<string>
        {
            $"{nameof(Comment.Work)}", 
            $"{nameof(Comment.User)}"
        };

        public CommentSearchAllSpecification(int workId, string text)
        {
            this.workId = workId;
            this.text = text;
        }

        public IQueryable<Comment> Apply(IQueryable<Comment> query)
        {
            return query.Where(x => x.TypeCommentId == workId && x.Text.Contains(text ?? string.Empty));
        }
    }
}