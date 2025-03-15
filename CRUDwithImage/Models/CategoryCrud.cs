namespace CRUDwithImage.Models
{
    public class CategoryCrud
    {
        private readonly ApplicationDbContex db;

        public CategoryCrud(ApplicationDbContex db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetCategories() { 
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id) { 
            return db.Categories.Where(x=>x.CategoryId==id).FirstOrDefault();
        }

        public int AddCategory(Category category) {
            int result = 0;
            db.Categories.Add(category);
            result= db.SaveChanges();
            return result;

        }

        public int UpdateCategory(Category category) {
            int result = 0;
            var cat1=db.Categories.Where(x=>x.CategoryId==category.CategoryId).FirstOrDefault();
            if (cat1 != null) { 
                cat1.CategoryName = category.CategoryName;
                result = db.SaveChanges();
            }
            return result;  
        }

        public int DeleteCategory(int id) {
            int result = 0;
            var cat1 = db.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            if (cat1 != null) { 
                db.Categories.Remove(cat1);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
