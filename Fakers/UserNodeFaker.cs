using Bogus;
using GraphQL1.Types;

namespace GraphQL1.Fakers;

public sealed class UserNodeFaker : Faker<UserNode> {
    public UserNodeFaker() {
        this.RuleFor(x => x.Id, f => f.Random.Int());
        this.RuleFor(x => x.Name, f => f.Name.FullName());
        this.RuleFor(x => x.AddressId, f => f.Random.Int());
    }
}
