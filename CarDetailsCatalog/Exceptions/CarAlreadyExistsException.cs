using System;

namespace CarDetailsCatalog.Exceptions
{
    public class CarAlreadyExistsException : Exception
    {
        public CarAlreadyExistsException() : base($"Such car already exists")
        {
        }
    }
}