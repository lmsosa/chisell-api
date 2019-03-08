using System;

namespace ChiSell.Infrastructure.Common.Exceptions
{
    public class InfrastructureException : Exception
    {
        public InfrastructureException(string message) : base(message)
        {
        }
    }
}
