using CRUD_Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Services.Services
{
    public interface ICategorysService
    {
        void AddNewCategory(CategoriesDTO categoriesDTO);
        void DeleteCategory(int number);
        void EditCategory(CategoriesDTO categoriesDTO);
        List<CategoriesDTO> GetAllCategory();
    }
}
