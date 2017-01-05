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
        int? Rent { get; }

        PropertyType propertyType { get; }

        Color color { get; }
    }
}
