using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TaskManager.Core.Entities
{
    public class Comment 
    {
        [Required]
        public string Text { get; set; }
        public DateTime? ReminderDate { get; set; }
        public Guid WorkId { get; set; }
        public Work Work { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int TypeCommentId { get; set; }
        public TypeComment Type { get; set; }
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
