using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ContactService
    {
        private readonly ContactDal contactDal;

        public ContactService()
        {
            contactDal = new ContactDal();
        }

        public Contact GetContact()
        {
            return contactDal.GetContact();
        }
    }
}
