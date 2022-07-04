using System;
using System.Linq;
using lks.DbContexts;
using lks.Models;
using lks.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class FireSafetySystemForBathController : Controller
    {
        private lksContext lksContext;
        
        public FireSafetySystemForBathController(lksContext lksContext)
        {
            this.lksContext = lksContext;
            DbHelper.dbContext = this.lksContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(CommentsLoader.Load<FireSafetySystemForBathController>(lksContext));
        }
        [HttpPost]
        public IActionResult Index(Comment comment)
        {
            comment.PageId = lksContext.Pages.Single(i => i.Name == CommentsLoader.GetControllerName<FireSafetySystemForBathController>()).Id;
            comment.UserId = lksContext.Users.Single(i => i.Email == User.Identity.Name).Id;
            comment.CreateDate = DateTime.Now;
            
            lksContext.Comments.Add(comment);
            lksContext.SaveChanges();
            
            Response.Redirect(Request.Path);
            
            return View(CommentsLoader.Load<FireSafetySystemForBathController>(lksContext));
        }
        
    }
}