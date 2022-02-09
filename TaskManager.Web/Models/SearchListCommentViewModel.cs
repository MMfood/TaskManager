using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Core.Entities;


namespace TaskManager.Web.Models
{
    public class SearchListCommentViewModel
    {
        public SearchListCommentViewModel(IEnumerable<Comment> entity)
        {
            this.CommentViewModels = new List<CommentViewModel>();

            foreach (var item in entity)
            {
                this.CommentViewModels.Add(new CommentViewModel
                {
                    Id = item.Id,
                    WorkId = item.WorkId,
                    Text = item.Text,
                    ReminderDate = item.ReminderDate,
                    UserName = item.User.UserName,
                    UserId = item.UserId,
                    TypeCommentId = item.TypeCommentId
                });
            }
        }


        public List<CommentViewModel> CommentViewModels { get; set; }
    }
}
