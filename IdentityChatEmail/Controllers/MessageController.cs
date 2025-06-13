using IdentityChatEmail.Context;
using IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmail.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

       
        public async Task<IActionResult> Inbox()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.email = values.Email;
            ViewBag.v1 = values.Name + " " + values.Surname;

            var values2 = _context.Messages.Where(x => x.ReceiverEmail == values.Email).ToList();

            return View(values2);
        }

        public async Task<IActionResult> SendBox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var email = user.Email;
            var messages = _context.Messages.Where(x => x.SenderEmail == email).ToList();
            return View(messages);
        }


        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
     
        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            message.SenderEmail = user.Email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("SendBox");
        }
    }
}