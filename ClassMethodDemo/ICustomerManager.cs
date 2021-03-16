using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    interface ICustomerManager
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void List();

    }
}
