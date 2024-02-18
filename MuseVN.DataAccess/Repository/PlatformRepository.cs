using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository; 
public class PlatformRepository : Repository<Platform>, IPlatformRepository {
    private ApplicationDbContext _db;

    public PlatformRepository(ApplicationDbContext db) : base(db){
        _db = db;
    }

    public void Update(Platform platform) {
        _db.Platforms.Update(platform);
    }
}
