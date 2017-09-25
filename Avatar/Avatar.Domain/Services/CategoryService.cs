using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;

namespace Avatar.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public void CreateCategory(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Category UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
