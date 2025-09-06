using DAL.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AboutCounterDal
    {
        private readonly DataContext context;

        public AboutCounterDal()
        {
            context = new DataContext();
        }
        public List<AboutCounter> GetAll()
        {
            return context.AboutCounters.ToList();
        }
    }
}
