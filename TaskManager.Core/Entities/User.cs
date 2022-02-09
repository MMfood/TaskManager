using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;



namespace TaskManager.Core.Entities
{
    public class User : IdentityUser
    {
        public ICollection<UserWork> UserWorks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
