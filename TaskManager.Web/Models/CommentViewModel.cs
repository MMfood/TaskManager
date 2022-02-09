using System;
using System.ComponentModel.DataAnnotations;
using TaskManager.Core.Entities;

namespace TaskManager.Web.Models
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Text { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string UserName { get; set; }
        [Required]
        public int TypeCommentId { get; set; }
        public Guid WorkId { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
