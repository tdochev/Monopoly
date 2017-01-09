using Monopoly.Enums;

namespace Monopoly.Contracts
{
	public interface IStreet : IProperty
	{
		Color Color { get; }
	}
}
