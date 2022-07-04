using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lks.Controllers;
using lks.DbContexts;
using lks.Utilities;
using Microsoft.AspNetCore.SignalR;

namespace lks
{
    public class ChatHub : Hub
    {
        private lksContext lksContext;
        
        public ChatHub(lksContext lksContext)
        {
            this.lksContext = lksContext;
        }
        public async Task Send(List<string> items)
        {
            var user = lksContext.Users.Single(i => i.Email == items[1]);

            var comment = new Comment() {Text=items[0], PageId = int.Parse(items[2]), UserId = user.Id, CreateDate = DateTime.Now};

            lksContext.Comments.Add(comment);
            lksContext.SaveChanges();

            var htmlSb = new StringBuilder();

            htmlSb.Append("<div class=\"container\">");
            htmlSb.Append("<div class=\"commentView\">");
            htmlSb.Append("<div class=\"commentInfo\">");
            htmlSb.Append($"<div class=\"comment__userName\">{user.Name}</div>");
            htmlSb.Append($"<div class=\"comment__data\">{comment.CreateDate}</div>");
            htmlSb.Append("<div class=\"comment__del\">");
            // htmlSb.Append("<li>");
            // htmlSb.Append("<a href=\"#\">");
            // htmlSb.Append("<i class=\"fa fa-times-circle-o\"></i>");
            // htmlSb.Append("</a>");
            // htmlSb.Append("</li>");
            htmlSb.Append("</div>");
            htmlSb.Append("</div>");
            htmlSb.Append("<div class=\"img\">");
            htmlSb.Append("<div class=\"inner\">");
            htmlSb.Append("<img width=\"100\" height=\"100\" src=\"images/NoPhoto.png\" alt=\"\">");
            htmlSb.Append("</div>");
            htmlSb.Append("</div>");
            htmlSb.Append("<circle cx=\"50\" cy=\"50\" r=\"50\" fill=\"img\"></circle>");
            htmlSb.Append($"<p>{comment.Text}</p>");
            htmlSb.Append("</div>");
            htmlSb.Append("</div>");
            
            await this.Clients.All.SendAsync("Send", htmlSb.ToString());
        }
    }
}