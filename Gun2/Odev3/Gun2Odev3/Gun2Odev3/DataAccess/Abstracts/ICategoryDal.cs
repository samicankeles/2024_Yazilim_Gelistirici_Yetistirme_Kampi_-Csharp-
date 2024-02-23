using System;
using Gun2Odev3.Entities.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Abstracts
{
	public interface ICategoryDal
	{
		List<Category> GetAll();
		Category GetById(int id);
		void Add(Category category);
		void Update(int oldCategoryId, Category newCategory);
		void Delete(Category category);
	}
}

