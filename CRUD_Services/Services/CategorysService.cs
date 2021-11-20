using CRUD_Repository.DTO;
using Paz_o.Models;
using Paz_o.Models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD_Services.Services
{
    public class CategorysService : ICategorysService
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
                Picture = categoriesDTO.Picture,
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
            throw new NotImplementedException();
        }

        public List<CategoriesDTO> GetAllCategory()
        {
            throw new NotImplementedException();
        }
    }
}
