using System;
using System.Collections.Generic;
using System.Linq;
using lks.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lks.Utilities
{
    public static class CommentsLoader
    {
        public static List<Comment> Load<T>(lksContext lksContext) where T : Controller
        {
            return  lksContext.Comments.
                Where(i => i.Page.Name == GetControllerName<T>()).
                Include(u => u.User).
                ToList();
        }

        public static string GetControllerName<T>() where T : Controller
        {
            return typeof(T).Name
                .Replace("Controller", string.Empty)
                .ToLower();
        }
    }
}