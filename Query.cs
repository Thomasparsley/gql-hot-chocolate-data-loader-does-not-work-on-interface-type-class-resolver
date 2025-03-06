using GraphQL1.Types;

namespace GraphQL1;

[QueryType]
public static class Query {
    public static async Task<IEnumerable<IUserNode>> GetAllUsersAsync(
        MemoryDatabase db,
        CancellationToken ct
    ) {
        var users = db.Users;
        await Task.Delay(30, ct);
        return users;
    }
    
    public static async Task<IEnumerable<UserNode>> GetUsersAsync(
        MemoryDatabase db,

        CancellationToken ct
    ) {
        var users = db.Users.OfType<UserNode>().ToList();
        await Task.Delay(30, ct);
        return users;
    }
    
    public static async Task<IEnumerable<AdminUserNode>> GetAdminUsersAsync(
        MemoryDatabase db,
        CancellationToken ct
    ) {
        var users = db.Users.OfType<AdminUserNode>().ToList();
        await Task.Delay(30, ct);
        return users;
    }
}
