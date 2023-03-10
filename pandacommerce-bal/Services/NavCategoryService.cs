using pandacommerce_dal.Interface;
using pandacommerce_dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pandacommerce_bal.Services
{

    public class NavCategoryService
    {
        public readonly INavCategory navCategory;
        public NavCategoryService(INavCategory navCategory)
        {
            this.navCategory = navCategory;
        }
        public async Task<NavCategory> AddNewCategory(NavCategory nav)
        {
            return await navCategory.Create(nav);
        }

        public IEnumerable<NavCategory> GetAllNavCategory()
        {
            try
            {
                return navCategory.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task DeleteNavigationCategory(int id)
        {

            try
            {
                var cat = navCategory.GetById(id);
                navCategory.Delete(cat);

            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task UpdateNavigationCategory(NavCategory obj)
        {
            try
            {
                navCategory.Update(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
