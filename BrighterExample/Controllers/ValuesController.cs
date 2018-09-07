using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brighter.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using Paramore.Brighter;

namespace BrighterExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly IAmACommandProcessor commandProcessor;
        public ValuesController(IAmACommandProcessor commandProcessor)
        {
            this.commandProcessor = commandProcessor;
        }

        // POST api/values
        [HttpPost("{value}")]
        public void Post(string value)
        {
            var command = new CreateValueCommand(value);
            commandProcessor.Send(command);
        }
    }
}
