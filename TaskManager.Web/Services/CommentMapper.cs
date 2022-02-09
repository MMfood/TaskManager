using TaskManager.Core.Entities;
using TaskManager.Web.Interfaces;
using TaskManager.Web.Models;

namespace TaskManager.Web.Services
{
    public class CommentMapper : IMapper<CommentViewModel, Comment>
    {
        public CommentViewModel Map(Comment entity)
        {
            return new CommentViewModel
            {
                Id = entity.Id,
                Text = entity.Text,
                UserId = entity.UserId,
                TypeCommentId = entity.TypeCommentId,
                ReminderDate = entity.ReminderDate,
                WorkId = entity.WorkId,
                UserName = entity.User.UserName,
                CreatedOn = entity.CreatedOn
            };
        }
    }
}
