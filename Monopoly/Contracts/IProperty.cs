using Monopoly.Models;

namespace Monopoly.Contracts
{
    public interface IProperty : ITile
    {

        int Price { get; }

        int Rent { get; }

        int MortgageValue { get; }

        Player Owner { get; set; }
    }
}
