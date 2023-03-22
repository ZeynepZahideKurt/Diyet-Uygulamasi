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
            return dbContext.Categories.OrderBy(a=>a.CategoryName).ToList();
        }

        public Category GetCategoryById(int categoryID)
        {
            return dbContext.Categories.Where(a => a.ID == categoryID).FirstOrDefault();
        }
        public Category GetCategoryByName(string categoryName)
        {
            return dbContext.Categories.Where(a => a.CategoryName == categoryName).FirstOrDefault();
        }
        public List<Category> GetCategoryByIdTurnList(int CategoryId)
        {
            return dbContext.Categories.Where(a => a.ID == CategoryId).ToList();
        }

        public List<Nutrient> GetNutrientByCategoryId(int categoryId)
        {
            var nutList = (from n in dbContext.Nutrients
                           join c in dbContext.Categories on n.CategoryID equals c.ID
                           where c.ID == categoryId
                           select n).OrderBy(a => a.NutrientName).ToList();

            return nutList;
        }

        //Admin
        public bool Insert(Category category)
        {
            dbContext.Categories.Add(category);
            return dbContext.SaveChanges() > 0;
        }
        //Admin
        public bool Update(Category category)
        {
            
            Category updateCategory = dbContext.Categories.Where(a => a.ID == category.ID).FirstOrDefault();
            updateCategory.CategoryName = category.CategoryName;
            return dbContext.SaveChanges() > 0;
        }
        //Admin
        public bool Delete(Category category)
        {
            Category deleteCategory = dbContext.Categories.Where(a => a.ID == category.ID).FirstOrDefault();
            dbContext.Categories.Remove(deleteCategory);
            return dbContext.SaveChanges() > 0;
        }


    }
}
