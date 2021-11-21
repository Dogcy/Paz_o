using CRUD_Repository.DTO;
using CRUD_Repository.Models;
using CRUD_Repository.Models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD_Services.Services
{
    public class CategorysService :ICategorysService
    {
        private readonly NorthwindContext _northwind;
        public CategorysService(NorthwindContext northwindContext)
        {
            this._northwind = northwindContext;
        }
        public void AddNewCategory(CategoriesDTO categoriesDTO)
        {
            _northwind.Categories.Add(new Category
            {
                CategoryName = categoriesDTO.CategoryName,
                Description = categoriesDTO.Description,

            });
            _northwind.SaveChanges();
        }

        public void DeleteCategory(int number)
        {
            var category = _northwind.Categories.Where(c => c.CategoryId == number).First();
            _northwind.Remove(category);
            _northwind.SaveChanges();
        }

        public void EditCategory(CategoriesDTO categoriesDTO)
        {
            var category = _northwind.Categories.Where(c => c.CategoryId == categoriesDTO.CategoryID).First();
            category.CategoryName = categoriesDTO.CategoryName;
            category.Description = categoriesDTO.Description;
            _northwind.SaveChanges();
        }

        public List<CategoriesDTO> GetAllCategory()
        {
            return _northwind.Categories.Select(
                c => new CategoriesDTO()
                {
                    CategoryID = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                }).ToList();
        }
    }
}
