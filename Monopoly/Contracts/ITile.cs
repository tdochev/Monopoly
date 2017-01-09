using Monopoly.Enums;

namespace Monopoly.Contracts
{
    public interface ITile
    {
        string Name { get; }

        TileType TileType { get; }
    }
}
