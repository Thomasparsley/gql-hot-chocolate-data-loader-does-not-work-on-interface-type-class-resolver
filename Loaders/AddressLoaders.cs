using GraphQL1.Types;

namespace GraphQL1.Loaders;

public static class AddressByIdLoader {
    [DataLoader]
    public static async Task<Dictionary<int, AddressNode>> GetAddressByIdAsync(
        IReadOnlyList<int> ids,
        MemoryDatabase db,
        CancellationToken cancellationToken
    ) {
        var idsString = string.Join(",", ids);
        Console.WriteLine($"GetAddressByIdAsync: {idsString}");
        await Task.Delay(15, cancellationToken);
        return db.Addresses.Where(x => ids.Contains(x.Id)).ToDictionary(x => x.Id);
    }
}
