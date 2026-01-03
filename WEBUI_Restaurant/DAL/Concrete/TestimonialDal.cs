using DAL.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class TestimonialDal
    {
        private readonly DataContext _context;

        public TestimonialDal()
        {
            _context = new DataContext();
        }

        public List<Testimonial> GetTestimonial(Expression<Func<Testimonial, bool>> filter = null)
        {
            var Testimon = _context.Testimonials.AsQueryable();

            if (filter != null)
            {
                Testimon = Testimon.Where(filter);
            }

            return Testimon.ToList();
        }
    }
}
