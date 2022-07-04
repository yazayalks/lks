using System;
using System.Linq;
using lks.DbContexts;
using lks.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class CommentController : Controller
    {
        private lksContext lksContext;

        public CommentController(lksContext lksContext)
        {
            this.lksContext = lksContext;
        }
        // GET
        public IActionResult Index(int id, string page)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var user = lksContext.Users.Single(i => i.Email == User.Identity.Name);
                    var userComment = lksContext.Comments.Single(i => i.Id == id);
                    if (userComment.UserId == user.Id)
                    {
                        lksContext.Comments.Attach(userComment);
                        lksContext.Comments.Remove(userComment);
                        lksContext.SaveChanges();
                        return RedirectPermanent("/"+page);
                    }
                }
            }
            catch (Exception e)
            {
                return RedirectPermanent("/Home");
            }
            
            
            return RedirectPermanent("/"+page);
        }
    }
}