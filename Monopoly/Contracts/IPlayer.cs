using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Contracts
{
    interface IPlayer
    {
        string Name { get; }

        int Money { get; }

        List<IProperty> GetProperties();

        void PlayTurn();

        void BuyPropery();

        void SellProperty();

        void MortgageProperty();

        
    }
}
