namespace GraphQL1.Types;

[InterfaceType("IUser")]
public interface IUserNode {
    public int Id { get; }
    public string Name { get; }
    public int AddressId { get; set; }
    public bool IsAdmin { get; }
}
