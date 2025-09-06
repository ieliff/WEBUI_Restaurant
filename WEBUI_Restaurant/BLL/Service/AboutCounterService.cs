using DAL.Concrete;
using Entity;   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AboutCounterService
    {
        private readonly AboutCounterDal aboutcounterDal;

        public AboutCounterService()
        {
            aboutcounterDal = new AboutCounterDal();
        }

        public List<AboutCounter> GetAll()
        {
            return aboutcounterDal.GetAll();
        }
    }
}
