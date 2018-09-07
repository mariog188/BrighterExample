using Paramore.Brighter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brighter.Domain.Commands
{
    public class CreateValueCommand : IRequest
    {
        public string Value { get; }

        public Guid Id { get; set; }

        public CreateValueCommand(string value)
        {
            Id = Guid.NewGuid();
            Value = value;
        }
    }
}
