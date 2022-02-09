using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Core.Entities;

namespace TaskManager.Core.Interfaces
{
    public interface ICommentService
    {
        Comment CreateComment(string text, string userId, Guid workId, DateTime? reminderDate, int typeCommentId);
        List<Comment> SearchAllComments(int workId, string text);
        List<Comment> GetAllComments(Guid workId);
        Comment FindCommentById(Guid id);
        Comment EditComment(Guid commentId, string text, string userId, int commentTypeId, DateTime? reminderDate);
        bool DeleteComment(Guid commentId);
    }
}
