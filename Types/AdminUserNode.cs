namespace GraphQL1.Types;

[GraphQLName("AdminUser")]
public class AdminUserNode : IUserNode {
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required int AddressId { get; set; }
    public bool IsAdmin => true;
}
