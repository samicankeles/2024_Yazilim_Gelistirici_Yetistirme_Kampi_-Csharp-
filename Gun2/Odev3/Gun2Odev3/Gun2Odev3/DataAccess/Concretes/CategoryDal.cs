using System;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Concretes
{
	public class CategoryDal : ICategoryDal
	{
        private List<Category> _categories;
		public CategoryDal()
		{
            _categories = new List<Category>
            {
                new Category
                {
                    Id = 2,
                    Name = "Başlangıç - Orta Seviye",
                    CourseIds = new List<int> {871, 98}
                },
                new Category
                {
                    Id = 5,
                    Name = "Orta - Üst Seviye",
                    CourseIds = new List<int> {3, 98}
                }
            };
		}

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            Category result = new Category();
            foreach (var category in _categories)
            {
                if (category.Id == id)
                {
                    result = category;
                    break;
                }
            }
            return result;
        }

        public void Update(int oldCategoryId, Category newCategory)
        {
            for (int i = 0; i < _categories.Count; i++)
            {
                if (_categories[i].Id == oldCategoryId)
                {
                    newCategory.Id = _categories[i].Id;
                    _categories[i] = newCategory;
                    break;
                }
            }
        }
    }
}

