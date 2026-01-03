using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class TestimonialService
    {
        private readonly TestimonialDal testimonialDal;
        public TestimonialService()
        {
            testimonialDal = new TestimonialDal();
        }
        public List<Testimonial> GetAllTestimonials()
        {
            return testimonialDal.GetTestimonial();
        }
    }
}
