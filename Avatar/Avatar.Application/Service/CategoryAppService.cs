using Avatar.Application.Interfaces;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Service
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void CreateCategory(CategoryViewModel category)
        {
            _categoryService.CreateCategory(category.ToDomain());
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return CategoryViewModel.ToViewModelList(_categoryService.GetAllCategories());
        }

        public CategoryViewModel GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel UpdateCategory(CategoryViewModel category)
        {
            throw new NotImplementedException();
        }
    }
}
