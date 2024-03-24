using System.Collections.Generic;

namespace CarDetailsCatalog.Models.Abstracts
{
    public interface IDetail
    {
        Dictionary<string, string> GetCharacteristics();
    }
}