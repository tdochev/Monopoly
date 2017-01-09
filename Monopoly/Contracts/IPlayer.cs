using System.Collections.Generic;

namespace Monopoly.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        int Money { get; }

        bool IsInJail { get; set; }

        List<IProperty> Properties { get; }

        void PlayTurn();

        void BuyProperty(IProperty property);

        void SellProperty();

        void MortgageProperty();

		void ThrowDice(IDice dice);
        
    }
}
