using System;
using Gun2Odev3.Business.Abstracts;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.Business.Concretes
{
	public class CategoryManager : ICategoryManager
	{
		private readonly ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
            _categoryDal = categoryDal;
		}

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Update(int oldCategoryId, Category newCategory)
        {
            _categoryDal.Update(oldCategoryId, newCategory);
        }
    }
}

