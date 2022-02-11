using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using TaskManager.Web.Interfaces;
using TaskManager.Web.Models;
using System.Linq;

namespace TaskManager.Web.Controllers{

    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        private readonly IMapper<CommentViewModel, Comment> commentMapper;
        public CommentController(ICommentService commentService, IMapper<CommentViewModel, Comment> commentMapper)
        {
            this.commentService = commentService;
            this.commentMapper = commentMapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateComment(Guid id)
        {
            var commentViewModel = new CommentViewModel();

            commentViewModel.WorkId = id;

            return View(commentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateComment(CommentViewModel viewModel)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var newComment = commentService.CreateComment(viewModel.Text, userId, viewModel.WorkId, viewModel.ReminderDate, viewModel.TypeCommentId);

                return RedirectToAction("Index", "Work");

            }
            catch (Exception)
            {
                return RedirectToAction("CreateComment", viewModel.Id);
            }
        }

        [HttpGet]
        public IActionResult SearchComment()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var allComments = this.commentService.GetAllComments(id);

            var CommentViewModel = new List<CommentViewModel>();

            foreach (var comment in allComments)
            {
                CommentViewModel.Add(this.commentMapper.Map(comment));
            }
            return View(CommentViewModel);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var comment = commentService.FindCommentById(id);
            var commentViewModel = new CommentViewModel();

            commentViewModel = commentMapper.Map(comment);

            return View(commentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CommentViewModel commentViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (commentViewModel.UserId != userId)
            {
                throw new ArgumentException("Вы не можете редактировать этот комментарий, потому что он создан кем-то другим.");
            }
            this.commentService.EditComment(commentViewModel.Id, commentViewModel.Text, userId, commentViewModel.TypeCommentId, commentViewModel.ReminderDate);

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

            this.commentService.DeleteComment(Id);

            return RedirectToAction("Index", "Work");
        }

        [HttpPost]
        public IActionResult Search(CommentViewModel commentViewModel)
        {
            var listComment = this.commentService.SearchAllComments(commentViewModel.TypeCommentId, commentViewModel.Text);
            var searchListViewModel = new SearchListCommentViewModel(listComment);
            return View(searchListViewModel);
        }
    }
}