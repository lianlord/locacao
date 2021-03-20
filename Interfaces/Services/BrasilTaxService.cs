using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    class BrasilTaxService : ITaxService
    {
        public override double Tax(double amount)
        {
            return amount <= 100 ? amount * .2 : amount * .15;
        }
    }
}
