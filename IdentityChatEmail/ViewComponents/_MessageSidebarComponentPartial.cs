using IdentityChatEmail.Context;
using IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmail.ViewComponents
{
    public class _MessageSidebarComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly EmailContext _emailContext;

        public _MessageSidebarComponentPartial(UserManager<AppUser> userManager, EmailContext emailContext)
        {
            _userManager = userManager;
            _emailContext = emailContext;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
