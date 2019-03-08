using System;

namespace ChiSell.Domain.Common
{
    public class State
    {
        public State()
        {
            Name = string.Empty;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}