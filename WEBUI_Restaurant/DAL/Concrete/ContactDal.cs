using DAL.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ContactDal
    {
        private readonly DataContext context;

        public ContactDal()
        {
            context = new DataContext();
        }

        public Contact GetContact()
        { 
            return context.ContactMessages.FirstOrDefault();
        }
    }
}
