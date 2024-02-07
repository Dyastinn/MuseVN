using MuseVN.DataAccess.Repository.IRepository;
using MuseVN.Models;
using MuseVNWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.DataAccess.Repository; 
internal class ProductRepository : Repository<Product>, IProductRepository {

    private ApplicationDbContext _db;

    public ProductRepository(ApplicationDbContext db) : base(db){
        _db = db;
    }
    public void Update(Product product) {
        _db.Products.Update(product);
    }


}
