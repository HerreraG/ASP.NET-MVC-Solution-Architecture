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
    public class GadgetService : IGadgetService {

        private readonly IGadgetRepository gadgetsRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public GadgetService(IGadgetRepository gadgetsRepository,
                            ICategoryRepository categoryRepository,
                            IUnitOfWork unitOfWork) {

            this.gadgetsRepository = gadgetsRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Gadget> GetGadgets() {
            var gadgets = this.gadgetsRepository.GetAll().ToList();
            return gadgets;
        }

        public IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null) {
            var category = this.categoryRepository.GetCategoryByName(categoryName);
            return category.Gadgets.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower()));
        }

        public Gadget GetGadget(int id) {
            var gadget = this.gadgetsRepository.GetById(id);
            return gadget;
        }

        public void CreateGadget(Gadget gadget) {
            this.gadgetsRepository.Add(gadget);
        }

        public void SaveGadget() {
            this.unitOfWork.Commit();
        }   
    }
}
