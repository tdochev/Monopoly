using Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Contracts
{
    interface IProperty : ITile
    {

        int Price { get; }

        int Rent { get; }

        int MortgageValue { get; }

        Color Color { get; }

        Player Owner { get; set; }
    }
}
