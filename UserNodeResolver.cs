using GraphQL1.Loaders;
using GraphQL1.Types;

namespace GraphQL1;

[InterfaceType<IUserNode>]
public static partial class UserNodeResolver {
    public static async Task<AddressNode> GetAddressAsync(
        [Parent] IUserNode user,
        IAddressByIdDataLoader loader,
        CancellationToken ct
    ) {
        var address = await loader.LoadAsync(user.AddressId, ct);
        return address!;
    }
}
