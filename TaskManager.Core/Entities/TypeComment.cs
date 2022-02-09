using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TaskManager.Core.Entities
{
    public class TypeComment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
