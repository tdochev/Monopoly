using Monopoly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        int Money { get; }

        List<IProperty> Properties { get; }

        void PlayTurn();

        void BuyProperty(IProperty property);

        void SellProperty();

        void MortgageProperty();

        
    }
}
