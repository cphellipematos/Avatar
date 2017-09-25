using Avatar.Application.ViewModel;
using System.Collections.Generic;

namespace Avatar.Application.Interfaces
{
    public interface ICategoryAppService
    {
        void CreateCategory(CategoryViewModel category);
        void DeleteCategory(int id);
        CategoryViewModel GetCategoryById(int id);
        IEnumerable<CategoryViewModel> GetAllCategories();
        CategoryViewModel UpdateCategory(CategoryViewModel category);
    }
}
