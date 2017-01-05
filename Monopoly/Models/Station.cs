using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Enums;

namespace Monopoly.Models
{
    public class Station : SpecailProperty
    {
        public Station(string name) : base(name, TileType.Station)
        {

        }
    }
}
