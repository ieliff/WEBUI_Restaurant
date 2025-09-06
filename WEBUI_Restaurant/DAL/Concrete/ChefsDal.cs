using DAL.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ChefsDal
    {
        private readonly DataContext context;

        public ChefsDal()
        {
            context = new DataContext();
        }


        public List<Chefs> GetAll()
        {
            return context.Chefs.ToList();
        }
    }
}
