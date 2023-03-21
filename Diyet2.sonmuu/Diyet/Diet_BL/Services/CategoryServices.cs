using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
    public class CategoryServices
    {
        CategoryRepository categoryRepository;

        public CategoryServices()
        {
            categoryRepository = new CategoryRepository();
        }

        public Category GetByCategoryId(int categoryId)
        {
            Category categorys = new Category();
            if (categoryId > 0)
            {
                categorys = categoryRepository.GetCategoryById(categoryId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return categorys;
        }

        public List<Category> GetByNutrientIdTurnList(int categoryId)
        {
            List<Category> categorys = new List<Category>();
            if (categoryId > 0)
            {
                categorys = categoryRepository.GetCategoryByIdTurnList(categoryId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return categorys;
        }

        public List<Category> GetList()
        {
            List<Category> categorys = new List<Category>();

            categorys = categoryRepository.GetAllCategory();

            return categorys;
        }
        public List<Nutrient> GetNutrientByCategoryId(int categoryId)
        {
            return categoryRepository.GetNutrientByCategoryId(categoryId);
        }
        public bool Insert(Category category)
        {
            return categoryRepository.Insert(category);
        }
        public bool Update(Category category)
        {
            return categoryRepository.Update(category);
        }
        public bool DeleteWithId(int categoryId)
        {

            Category n = categoryRepository.GetCategoryById(categoryId);
            return categoryRepository.Delete(n);
        }
        public bool Delete(Category category)
        {

            return categoryRepository.Delete(category);
        }

    }
}
