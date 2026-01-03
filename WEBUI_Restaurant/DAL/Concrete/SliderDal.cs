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
    public class SliderDal
    {
        private readonly DataContext context;

        public SliderDal()
        {
            context = new DataContext();
        }

        public List<Slider> GetAll()
        {
            return context.Sliders.ToList();
        }
    }
}
