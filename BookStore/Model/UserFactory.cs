using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class UserFactory
    {

        public User CreateUser(UserType? type)
        {
            User user = null;
            if (type == null)
            {
                user = new User();
            }
            else if (type == UserType.CUSTOMER)
            {
                user = new Customer();
            }
            else if (type == UserType.ADMIN)
            {
                user = new Admin();
            }
            return user;
        }
    }
}
