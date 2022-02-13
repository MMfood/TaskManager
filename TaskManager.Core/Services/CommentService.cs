using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using TaskManager.Core.Specifications;
using TaskManager.Core.Validations;


namespace TaskManager.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> commentRepository;
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Work> workRepository;
        private readonly IWorkService workService;
        public CommentService(IWorkService workService, IRepository<Comment> commentRepository, IRepository<User> userRepository, IRepository<Work> workRepository)
        {
            this.workService = workService;
            this.commentRepository = commentRepository;
            this.userRepository = userRepository;
            this.workRepository = workRepository;
        }
        public Comment CreateComment(string text, string userId, Guid workId, DateTime? reminderDate, int typeCommentId)
        {
            ValidationComment.ValidateCommentTextIfIsNullOrEmpty(text);
            Work findWork =  workService.FindWorkById(workId);
            var currentUser = userRepository.List(new UsersGetAllSpecification()) 
                .FirstOrDefault(u => u.Id == userId);

            Guid commentId = Guid.NewGuid();

            var comment = new Comment
            {
                Id = commentId,
                Text = text,
                UserId = userId,
                Work = null,
                WorkId = workId,
                CreatedOn = DateTime.Now,
                TypeCommentId = typeCommentId,
                User = null,
                ReminderDate = reminderDate
            };

            
            if (reminderDate != null)
            {
                var work = workRepository.Get(workId);
                work.NextActionDate = reminderDate;
            }
            
            commentRepository.Add(comment);
            //var testcomment = commentRepository.Get(commentId);
            return comment;
        }
        public List<Comment> SearchAllComments(int workId, string text)
        {
            return commentRepository
                .List(new CommentSearchAllSpecification(workId, text))
                .ToList();
        }
        public List<Comment> GetAllComments(Guid workId)
        {
            return commentRepository
                .List(new CommentGetAllByWorkIdSpecification(workId))
                .ToList();
        }
        public  bool DeleteComment(Guid commentId)
        {
            var comment = commentRepository
                .List(new CommentGetAllSpecification())
                .FirstOrDefault(c => c.Id == commentId);

            if (comment == null)
            {
                return false;
            }

            commentRepository.Delete(comment);
            return true;
        }

        public Comment FindCommentById(Guid id)
        {
            var comment = commentRepository
                .List(new CommentWithUserSpecification())
                .FirstOrDefault(x => x.Id == id);

            return comment;
        }

        public Comment EditComment(Guid commentId, string text, string userId, int commentTypeId, DateTime? reminderDate)
        {
            ValidationComment.ValidateCommentTextIfIsNullOrEmpty(text);
            var comment = commentRepository
                .List(new CommentWithUserSpecification())
                .FirstOrDefault(c => c.Id == commentId);

            if (comment == null)
            {
                throw new ArgumentException("Комментарий уже существует");
            }

            comment.Text = text;
            comment.TypeCommentId = commentTypeId;
            comment.ModifiedOn = DateTime.Now;
            comment.ReminderDate = reminderDate;
            if (reminderDate != null && comment.ReminderDate != reminderDate)
            {
                comment.Work.NextActionDate = reminderDate;
            }
            commentRepository.Update(comment);
            return comment;
        }

        public List<Comment> GetAllCommentsForUser(string userId)
        {
            return commentRepository
                .List(new CommentGetAllByUserIdSpesification(userId))
                .ToList();
        }

    }
}
