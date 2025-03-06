using Bogus;
using GraphQL1.Types;

namespace GraphQL1.Fakers;

public sealed class AddressNodeFaker : Faker<AddressNode> {
    public AddressNodeFaker() {
        this.RuleFor(x => x.Id, f => f.Random.Int());
        this.RuleFor(x => x.Street, f => f.Address.StreetName());
    }
}
