using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class CategoryRepository
    {

        AppDbContext dbContext;
        public CategoryRepository()
        {
            dbContext = new AppDbContext();
        }

        public List<Category> GetAllCategory()
        {
            return dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int categoryID)
        {
            return dbContext.Categories.Where(a => a.ID == categoryID).FirstOrDefault();
        }

        public bool Insert(Category category)
        {
            dbContext.Categories.Add(category);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(Category category)
        {
            Category updateCategory = dbContext.Categories.Where(a => a.ID == category.ID).FirstOrDefault();
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(Category category)
        {
            Category deleteCategory = dbContext.Categories.Where(a => a.ID == category.ID).FirstOrDefault();
            dbContext.Categories.Remove(deleteCategory);
            return dbContext.SaveChanges() > 0;
        }


    }
}
