using System;

namespace BofhDotNet.IrcBotCommon
{
    public class IrcBotException : Exception
    {
        public IrcBotException(IrcBotExceptionType type, string message)
            : base(message)
        {
        }
    }

    public enum IrcBotExceptionType
    {
        Unknown,
        NoConnection,
    }   
}
