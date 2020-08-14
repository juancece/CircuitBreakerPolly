using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErrorApi.Controllers
{
    [Route("message")]
    public class MessageController : Controller
    {
        private IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("hello")]
        public async Task<IActionResult> GetHello()
        {
            var result = await _messageService.GetHelloMessage();
            return Ok(result);
        }

        [HttpGet("goodbye")]
        public async Task<IActionResult> GetGoodbye()
        {
            var result = await _messageService.GetGoodbyeMessage();
            return Ok(result);
        }

    }
}
