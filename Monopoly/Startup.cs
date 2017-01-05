using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Models;

namespace Monopoly
{
    class Startup
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Board.GetTileAt(0).Name);
        }
    }
}
