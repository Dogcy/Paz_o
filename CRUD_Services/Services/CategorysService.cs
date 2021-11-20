using CRUD_Repository.DTO;
using Paz_o.Models;
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
            throw new NotImplementedException();
        }

        public void DeleteCategory(string number)
        {
            throw new NotImplementedException();
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
