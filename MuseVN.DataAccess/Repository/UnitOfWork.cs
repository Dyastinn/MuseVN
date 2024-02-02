using MuseVN.DataAccess.Repository.IRepository;
using MuseVNWeb.DataAccess.Data;


namespace MuseVN.DataAccess.Repository {
    public class UnitOfWork : IUnitOfWork {

        private ApplicationDbContext _db;

        public ICategoryRepository Category { get; set; }
        public UnitOfWork(ApplicationDbContext db){
            _db = db;
            Category = new CategoryRepository(_db);
        }
        public void Save() {
            _db.SaveChanges();
        }

    }


}
