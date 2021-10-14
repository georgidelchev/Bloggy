using System.Collections.Generic;

namespace Bloggy.Services.Data
{
    public interface ISettingsService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
