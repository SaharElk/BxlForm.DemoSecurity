using BxlForm.DemoSecurity.Models.Client.Data;
using BxlForm.DemoSecurity.Models.Client.Mappers;
using BxlForm.DemoSecurity.Models.Client.Repositories;
using GR = BxlForm.DemoSecurity.Models.Global.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace BxlForm.DemoSecurity.Models.Client.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly GR.ICategoryRepository _globalRepository;

        public CategoryService(GR.ICategoryRepository globalRepository)
        {
            _globalRepository = globalRepository;
        }

        public IEnumerable<Category> Get()
        {
            return _globalRepository.Get().Select(c => c.ToClient());
        }

        public void Insert(Category category)
        {
            _globalRepository.Insert(category.ToGlobal());
        }

        public void Update(int id, Category category)
        {
            _globalRepository.Update(id, category.ToGlobal());
        }

        public void Delete(int id)
        {
            _globalRepository.Delete(id);
        }
    }
}
