using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AboutService
    {
        private readonly AboutDal aboutDal;

        public AboutService()
        {
            aboutDal = new AboutDal();
        }
        public About GetAbout()
        {
            return aboutDal.GetAbout();
        }

        public async Task UpdateAboutAsync(About about)
        {
            await aboutDal.UpdateAboutAsync(about);
        }
    }
}

