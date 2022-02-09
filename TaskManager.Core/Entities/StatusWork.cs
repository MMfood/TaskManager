using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager.Core.Entities
{
    public class StatusWork
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
