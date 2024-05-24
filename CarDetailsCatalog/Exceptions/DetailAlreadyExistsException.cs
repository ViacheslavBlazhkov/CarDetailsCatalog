using System;

namespace CarDetailsCatalog.Exceptions
{
    public class DetailAlreadyExistsException : Exception
    {
        public DetailAlreadyExistsException() : base($"Such detail already exists")
        {
        }
    }
}