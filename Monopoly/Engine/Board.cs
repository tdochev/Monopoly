using Monopoly.Models;
using Monopoly.Contracts;
using Monopoly.Enums;
using Monopoly.Common;

namespace Monopoly.Engine
{
    public static class Board
    {
        private static readonly ITile[] tiles =
        {
            new Tile(TilesConstants.GO, TileType.GO),
			new Street(PropertyConstants.MEDITERRANEAN_AVENUE_NAME, Color.DarkPurple, PropertyConstants.MEDITERRANEAN_AVENUE_PRICE, PropertyConstants.MEDITERRANEAN_AVENUE_MORTGAGE_VALUE, PropertyConstants.MEDITERRANEAN_AVENUE_RENT),
            new Tile(TilesConstants.COMMUNITY_CHEST, TileType.CommunityChest),
            new Street(PropertyConstants.BALTIC_AVENUE_NAME, Color.DarkPurple, PropertyConstants.BALTIC_AVENUE_PRICE, PropertyConstants.BALTIC_AVENUE_MORTGAGE_VALUE,PropertyConstants.BALTIC_AVENUE_RENT),
            new Tile(TilesConstants.INCOME_TAX,TileType.IncomeTax),
            new Station(PropertyConstants.READING_RAILROAD_NAME),
            new Street(PropertyConstants.ORIENTAL_AVENUE_NAME, Color.LightBlue, PropertyConstants.ORIENTAL_AVENUE_PRICE, PropertyConstants.ORIENTAL_AVENUE_MORTGAGE_VALUE, PropertyConstants.ORIENTAL_AVENUE_RENT),
            new Tile(TilesConstants.CHANCE, TileType.Chance),
            new Street(PropertyConstants.VERMONT_AVENUE_NAME, Color.LightBlue, PropertyConstants.VERMONT_AVENUE_PRICE,PropertyConstants.VERMONT_AVENUE_MORTGAGE_VALUE, PropertyConstants.VERMONT_AVENUE_RENT),
            new Street(PropertyConstants.CONNECTICUT_AVENUE_NAME, Color.LightBlue, PropertyConstants.CONNECTICUT_AVENUE_PRICE, PropertyConstants.CONNECTICUT_AVENUE_MORTGAGE_VALUE, PropertyConstants.CONNECTICUT_AVENUE_RENT),
            new Tile(TilesConstants.JAIL_JUST_VISITNG, TileType.JailVisitingJail),
            new Street(PropertyConstants.ST_CHARLES_PLACE_NAME, Color.Pink, PropertyConstants.ST_CHARLES_PLACE_PRICE, PropertyConstants.ST_CHARLES_PLACE_MORTGAGE_VALUE, PropertyConstants.ST_CHARLES_PLACE_RENT),
            new Utility(PropertyConstants.ELECTRIC_COMPANY_NAME),
            new Street(PropertyConstants.STATES_AVENUE_NAME, Color.Pink, PropertyConstants.STATES_AVENUE_PRICE, PropertyConstants.STATES_AVENUE_MORTGAGE_VALUE, PropertyConstants.STATES_AVENUE_RENT),
            new Street(PropertyConstants.VIRGINIA_AVENUE_NAME, Color.Pink, PropertyConstants.VIRGINIA_AVENUE_PRICE, PropertyConstants.VIRGINIA_AVENUE_MORTGAGE_VALUE, PropertyConstants.VIRGINIA_AVENUE_RENT),
            new Station(PropertyConstants.PENNSYLVANIA_RAILROAD_NAME),
            new Street(PropertyConstants.ST_JAMES_PLACE_NAME, Color.Orange, PropertyConstants.ST_JAMES__PLACE_PRICE, PropertyConstants.ST_JAMES__PLACE_MORTGAGE_VALUE, PropertyConstants.ST_JAMES__PLACE_RENT),
            new Tile(TilesConstants.COMMUNITY_CHEST, TileType.CommunityChest),
            new Street(PropertyConstants.TENNESSEE_AVENUE_NAME, Color.Orange, PropertyConstants.TENNESSEE_AVENUE_PRICE, PropertyConstants.TENNESSEE_AVENUE_MORTGAGE_VALUE, PropertyConstants.TENNESSEE_AVENUE_RENT),
            new Street(PropertyConstants.NEW_YORK_AVENUE_NAME, Color.Orange, PropertyConstants.NEW_YORK_AVENUE_PRICE, PropertyConstants.NEW_YORK_AVENUE_MORTGAGE_VALUE, PropertyConstants.NEW_YORK_AVENUE_RENT),
            new Tile(TilesConstants.FREE_PARKING, TileType.FreeParking)
        };

        public static ITile GetTileAt(int index)
        {
            return tiles[index];
        }
    }
}
