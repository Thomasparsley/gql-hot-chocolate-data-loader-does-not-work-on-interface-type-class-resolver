using GraphQL1.Fakers;
using GraphQL1.Types;

namespace GraphQL1;

public class MemoryDatabase {
    
    private readonly List<IUserNode> _users = [];
    private readonly List<AddressNode> _addresses = [];
    
    public IReadOnlyList<IUserNode> Users => this._users;
    public IReadOnlyList<AddressNode> Addresses => this._addresses;
    
    public MemoryDatabase() {
        var addressFaker = new AddressNodeFaker();
        var userFaker = new UserNodeFaker();
        var adminUserFaker = new AdminUserNodeFaker();
        
        foreach (var idx in Enumerable.Range(0, 50)) {
            var address = addressFaker.Generate();
            
            IUserNode user;
            if (idx % 2 == 0) {
                user = userFaker.Generate();
            }
            else {
                user = adminUserFaker.Generate();
            }
            
            user.AddressId = address.Id;
            
            this._users.Add(user);
            this._addresses.Add(address);
        }
    }
}
