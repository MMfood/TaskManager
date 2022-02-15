using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Services;
using TaskManager.Core.Interfaces;
using TaskManager.Web.Interfaces;
using TaskManager.Web.Models;
using TaskManager.Core.Entities;
using System.Linq;

namespace TaskManager.Web.Controllers
{
   
    public class WorkController : Controller
    {
        private readonly IMapper<WorkViewModel, Work> workMapper;
        private readonly IWorkService workService;
        private readonly IUserService userService;
        public WorkController(IMapper<WorkViewModel, Work> workMapper, IWorkService workService, IUserService userService)
        {
            this.workMapper = workMapper;
            this.workService = workService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var works = this.workService.GetAllWorksForUser(userId);
            //var testWorks = this.workService.GetAll();
            var workViewModel = new List<WorkViewModel>();

            foreach (var work in works)
            {
                workViewModel.Add(this.workMapper.Map(work));
            }

            return View(workViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            var allUsers = this.userService.GetAllUsers();
            var workViewModel = new WorkViewModel();
            workViewModel.AllUsers = allUsers;
            return View(workViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(WorkViewModel workViewModel)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                this.workService.CreateWork(workViewModel.WorkName, workViewModel.Description, userId, workViewModel.DueTime, workViewModel.TypeWork, workViewModel.AllUsers, workViewModel.NextActionDate);


                return RedirectToAction("Index", "Work");
            }
            catch (Exception)
            {
                return RedirectToAction("Create", workViewModel.Id);
            }
        }

        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult Edit(Guid id)
        {
            var users = this.userService.GetAllUsersForWork(id);
            var work = this.workService.FindWorkById(id);
            var workViewModel = this.workMapper.Map(work);
            workViewModel.AllUsers = users;
            return View(workViewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(WorkViewModel workViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            var allUsers = this.userService.GetAllUsersForWork(workViewModel.Id);
            this.workService.EditWork(workViewModel.Id, workViewModel.WorkName, workViewModel.Description, workViewModel.DueTime, workViewModel.StatusWork, allUsers);

            return RedirectToAction("Index", "Work");
        }


        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult Delete(Guid Id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            this.workService.DeleteWork(Id);

            return RedirectToAction("Index", "Work");
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            Work work = this.workService.FindWorkById(id);
            WorkViewModel workViewModel = this.workMapper.Map(work);
            var allUsers = this.userService.GetSelectedUsers(id);
            workViewModel.AllUsers = allUsers;
            return View(workViewModel);
        }
    }
}