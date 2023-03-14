using Microsoft.AspNetCore.Identity;

namespace StoreApi
{
    public class Store
    {
        public Store(int id, string name, string storeIdGuid)
        {
            Id = id;
            Name = name;
            StoreIdGuid = storeIdGuid;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        //public Guid StoreIdGuid { get; private set; }
        public string StoreIdGuid { get; private set; }

    }
}