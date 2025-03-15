namespace CRUDwithImage.Models
{
    public class Product1crud
    {
        private readonly ApplicationDbContex db;

        public Product1crud(ApplicationDbContex db) { 
        this.db = db;
        }

        public IEnumerable<Product1> GetProduct1s() { 
           var model=(from p in db.Product1s 
                     join
                     c in db.Categories 
                     on p.categoryId equals c.CategoryId
                     select new Product1 { 
                     productId=p.productId,
                     productName=p.productName,
                     price=p.price,
                     imageUrl=p.imageUrl,
                     categoryId=c.CategoryId,
                     CategoryName=c.CategoryName,
                     }).ToList();
            return model;
        }

        public Product1 GetProduct1ById(int id) {
            return db.Product1s.Where(x => x.productId == id).FirstOrDefault();
        }

        public int AddProduct(Product1 product)
        {
            int result = 0;
            db.Product1s.Add(product);
            result = db.SaveChanges();
            return result;

        }

        public int UpdateProduct(Product1 product)
        {
            int result = 0;
            var pro1 = db.Product1s.Where(x => x.productId == product.productId).FirstOrDefault();
            if (pro1 != null)
            {
                pro1.productName = product.productName;
                pro1.price = product.price;
                pro1.imageUrl = product.imageUrl;
                pro1.categoryId = product.categoryId;


                result = db.SaveChanges();
            }
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var pro1 = db.Product1s.Where(x => x.productId== id).FirstOrDefault();
            if (pro1 != null)
            {
                db.Product1s.Remove(pro1);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
