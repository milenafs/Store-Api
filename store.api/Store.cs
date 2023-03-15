using Microsoft.AspNetCore.Identity;

namespace Store.Api
{
    public class Store
    {
        public Store() { }
        public Store(int id, string name, Guid storeIdGuid)
        {
            Id = id;
            Name = name;
            StoreIdGuid = storeIdGuid;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public Guid StoreIdGuid { get; private set; }

        public bool Validate ()
        {
            if (Name == null || Name == "")
                return false;
            
            return true;
        }

    }
}