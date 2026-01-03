using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ChefsService
    {
        private readonly ChefsDal chefsDal;

        public ChefsService()
        {
            chefsDal = new ChefsDal();
        }

        public List<Chefs> GetAllChefs()
        {
            return chefsDal.GetAll();
        }
    }
}
