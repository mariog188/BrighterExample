using Brighter.Domain.Commands;
using Paramore.Brighter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Brighter.Domain.Handlers
{
    public class CreateValueCommandHandler : RequestHandler<CreateValueCommand>
    {
        public override CreateValueCommand Handle(CreateValueCommand command)
        {
            Debug.WriteLine($"Creating Value {command.Value}");
            return base.Handle(command);
        }
    }
}
