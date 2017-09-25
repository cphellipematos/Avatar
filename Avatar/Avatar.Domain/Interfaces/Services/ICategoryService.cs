using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        void DeleteCategory(int id);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        Category UpdateCategory(Category category);
    }
}
