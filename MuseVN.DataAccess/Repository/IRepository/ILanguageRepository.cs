using MuseVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository.IRepository; 
public interface ILanguageRepository: IRepository<Language> {

    void Update(Language language);
}
