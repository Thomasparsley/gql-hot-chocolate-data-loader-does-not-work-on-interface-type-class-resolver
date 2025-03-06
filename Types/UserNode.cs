namespace GraphQL1.Types;

[GraphQLName("User")]
public class UserNode : IUserNode {
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required int AddressId { get; set; }
    public bool IsAdmin => false;
}
