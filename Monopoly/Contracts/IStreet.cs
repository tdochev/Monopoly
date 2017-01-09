using Monopoly.Contracts;
using Monopoly.Enums;

namespace Monopoly
{
	public interface IStreet : IProperty
	{
		Color Color { get; }
	}
}
