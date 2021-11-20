using CRUD_Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Services.Services
{
    internal interface ICategorysService
    {
        void AddNewCategory(CategoriesDTO categoriesDTO);
        void DeleteCategory(string number);
        void EditCategory(CategoriesDTO categoriesDTO);
        List<CategoriesDTO> GetAllCategory();
    }
}
