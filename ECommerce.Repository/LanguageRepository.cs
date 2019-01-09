using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Languages;

namespace ECommerce.Repository
{
    public class LanguageRepository : Repository<Language, Guid>, ILanguageRepository
    {
        public LanguageRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
