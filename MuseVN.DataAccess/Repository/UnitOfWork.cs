using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;


namespace MuseVN.DataAccess.Repository {
    public class UnitOfWork : IUnitOfWork {

        private ApplicationDbContext _db;

        public ICategoryRepository Category { get; set; }
        public IProductRepository Product { get; set; }

        public ITagRepository Tag { get; set; }

        public ILanguageRepository Language { get; set; }

        public IPlatformRepository Platform { get; set; }

        public UnitOfWork(ApplicationDbContext db){
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Tag = new TagRepository(_db);
            Language = new LanguageRepository(_db);
            Platform = new PlatformRepository(_db);
            
        }
        public void Save() {
            _db.SaveChanges();
        }

    }


}
