using System;
using System.Collections.Generic;
using TaskManager.Core.Enums;
using System.ComponentModel.DataAnnotations;


namespace TaskManager.Core.Entities
{
    public class Work 
    {
        public string WorkName { get; set; }
        public DateTime? DueDate { get; set; }
        public string Description { get; set; }
        public ICollection<UserWork> UserWorks { get; set; }
        public DateTime? NextActionDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int TypeWorkId { get; set; }
        public TypeWork Type { get; set; }
        public int StatusWorkId { get; set; } = (int)WorkStatus.Open;
        public StatusWork Status { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
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
