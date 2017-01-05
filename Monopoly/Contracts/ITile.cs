using Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Contracts
{
    public interface ITile
    {
        string Name { get; }

        TileType TileType { get; }
    }
}
