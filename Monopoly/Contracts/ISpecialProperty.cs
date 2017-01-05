using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Contracts
{
    interface ISpecialProperty
    {
        int Price { get; }

        int Rent { get; }

        int MortgageValue { get; }

        Player Owner { get; set; }
    }
}
