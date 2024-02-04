using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBackgroundServices.Domain;
using WebApiBackgroundServices.Repository;
using WebApiBackgroundServices.Services;

namespace WebApiBackgroundServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private ICommandRepository _commandRepository;
        private IChatProService _chatProService;

        public CommandController(ICommandRepository commandRepository, IChatProService chatProService)
        {
            _commandRepository = commandRepository;
            _chatProService = chatProService;
        }

        [HttpPost]
        public IActionResult SetCommand([FromBody] Message message)
        {
            _commandRepository.SetMessage(message);

            return Ok(_commandRepository.GetMessage());
        }

        [HttpGet]
        public IActionResult GetToken()
        {
            _chatProService.GetTokenMessage();
            return Ok();
        }
    }
}
