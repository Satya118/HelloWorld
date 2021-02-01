using Infrastructure.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private IMessageRepository _messageRepository;
        public HelloWorldController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var messageObj = await _messageRepository.GetMessageObject();
            return Ok(messageObj.Message);
        }
    }
}
