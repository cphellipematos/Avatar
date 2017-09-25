using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class CategoryViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool status { get; set; }

        public static CategoryViewModel ToViewModel(Category category)
        {
            return new CategoryViewModel()
            {
                id = category.Id,
                name = category.Name,
                description = category.Description,
                status = category.Status
            };
        }

        public static IEnumerable<CategoryViewModel> ToViewModelList(IEnumerable<Category> categories)
        {
            if (categories == null)
                return new List<CategoryViewModel>();

            var categoriesViewModel = new List<CategoryViewModel>();

            foreach (var categorie in categories)
            {
                categoriesViewModel.Add(ToViewModel(categorie));
            }

            return categoriesViewModel;
        }

        public Category ToDomain()
        {
            return new Category(id, name, description, status);
        }
    }
}
