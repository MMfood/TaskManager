
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskManager.Core.Entities;


namespace TaskManager.Web.Models
{
    public class WorkViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Name")]
        public string WorkName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Description { get; set; }
        [Display(Name = "Required by date")]
        public DateTime? DueTime { get; set; }
        public List<UserConstruct> AllUsers { get; set; }
        [Display(Name = "Type")]
        public int TypeWork { get; set; }
        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public int StatusWork { get; set; }
        public DateTime? NextActionDate { get; set; }
        [Display(Name = "Created")]
        public DateTime? CreatedOn { get; set; }
    }
}
