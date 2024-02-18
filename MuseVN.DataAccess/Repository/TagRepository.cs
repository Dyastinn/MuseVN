using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository;
public class TagRepository : Repository<Tag>, ITagRepository {

    private ApplicationDbContext _db;
    public TagRepository(ApplicationDbContext db) : base(db) {
        _db = db;
    }

    public void Update(Tag tag) {
        _db.Tags.Update(tag);
    }
}
