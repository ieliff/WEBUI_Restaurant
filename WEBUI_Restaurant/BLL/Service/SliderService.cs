using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SliderService
    {
        private readonly SliderDal sliderDal;

        public SliderService()
        {
            sliderDal = new SliderDal();
        }
        public List<Slider> GetAll()
        {
            return sliderDal.GetAll();
        }
    }
}
