using System;

namespace CarDetailsCatalog.Exceptions
{
    public class UnknownMenuException : Exception
    {
        public UnknownMenuException() : base($"Unknown menu")
        {
        }
    }
}