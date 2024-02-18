using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository; 
public class LanguageRepository : Repository<Language>, ILanguageRepository {
    private ApplicationDbContext _db;

    public LanguageRepository(ApplicationDbContext db) : base(db) {
        _db = db;
    }

    public void Update(Language language) {
        _db.Languages.Update(language);
    }

}
