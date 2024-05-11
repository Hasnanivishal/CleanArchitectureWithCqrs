using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customer.Contracts
{
    public class CustomerResponse
    {
        public Guid CustomerId { get; set; }

        public string Name { get; set; }

        public double AvailableBalance { get; set; }
    }
}
