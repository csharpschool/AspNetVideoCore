using AspNetVideoCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetVideoCore.ViewComponents
{
    public class Message : ViewComponent
    {
        private IMessageService _message;

        public Message(IMessageService message)
        {
            _message = message;
        }

        public IViewComponentResult Invoke()
        {
            var model = _message.GetMessage();
            return View("Default", model);
        }

    }
}
