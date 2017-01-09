using Monopoly.Models;

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
