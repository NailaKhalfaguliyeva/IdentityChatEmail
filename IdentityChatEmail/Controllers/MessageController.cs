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


        public async Task<IActionResult> Inbox(string search)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userEmail = user.Email;
            ViewBag.email = userEmail;
            ViewBag.namesurname = user.Name + " " + user.Surname;
            ViewBag.SearchTerm = search;
            var messages = _context.Messages
                .Where(x => x.ReceiverEmail == userEmail && x.IsRead == true);

            if (!string.IsNullOrEmpty(search))
            {
                messages = messages.Where(x => x.Subject.ToLower().Contains(search.ToLower()));
            }

            return View(messages.ToList());
        }

        public async Task<IActionResult> SendBox(string search)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string emailValue = values.Email;
            var sendMessageList = _context.Messages.Where(x => x.SenderEmail == emailValue).ToList();
            ViewBag.Search = search;

            return View(sendMessageList);
        
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
            TempData["SuccessMessage"] = "Message sent successfully.!";
            return RedirectToAction("SendBox");
        }


        public async Task< IActionResult> MessageDetail(int id)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.senderimage = values.ProfileImageUrl;
            var value = _context.Messages.FirstOrDefault(x => x.MessageId == id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeMessageStatus(List<int> MessageId)
        {
            foreach (var id in MessageId)
            {
                var value = await _context.Messages.FindAsync(id);
                if (value.IsRead != null || value.IsRead == false)
                {
                    value.IsRead = true;

                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("TrashBox");
        }

        public IActionResult TrashBox()
        {
            var deletedValues = _context.Messages.Where(x => x.IsRead == false).ToList();
            return View(deletedValues);
        }
    }
}
