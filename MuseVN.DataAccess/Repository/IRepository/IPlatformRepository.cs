using MuseVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository.IRepository; 
public interface IPlatformRepository : IRepository<Platform> {

    void Update(Platform platform);
}
