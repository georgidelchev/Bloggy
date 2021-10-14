using System.Collections.Generic;
using System.Linq;

using Bloggy.Data.Common.Repositories;
using Bloggy.Data.Models;
using Bloggy.Services.Mapping;

namespace Bloggy.Services.Data
{
    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(
            IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
            => this.settingsRepository.AllAsNoTracking().Count();

        public IEnumerable<T> GetAll<T>()
            => this.settingsRepository.All().To<T>().ToList();
    }
}
