using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository.IRepository; 
public interface IUnitOfWork {
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }

    ITagRepository Tag { get; }

    ILanguageRepository Language { get; }

    IPlatformRepository Platform { get; }
    public void Save();
}
