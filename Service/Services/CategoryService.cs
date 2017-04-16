using Service.IServices;
using Store.Data.Infrastructure;
using Store.Data.IRepositories;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services {
    public class CategoryService : ICategoryService {

        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository,
                               IUnitOfWork unitOfWork) {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories(string name = null) {
            if(string.IsNullOrEmpty(name)) {
                return this.categoryRepository.GetAll().ToList();
            } else {
                return this.categoryRepository.GetAll().Where(c => c.Name == name));
            }
        }

        public Category GetCategory(int id) {
            var category = this.categoryRepository.GetById(id);
            return category;
        }

        public Category GetCategory(string name) {
            var category = this.categoryRepository.GetCategoryByName(name);
            return category;
        }

        public void CreateCategory(Category category) {
            this.categoryRepository.Add(category);
        }

        public void SaveCategory() {
            this.unitOfWork.Commit();
        }
    }
}
