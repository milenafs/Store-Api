namespace Store.MVC.Models
{
    public class Store
    {
        public Store() { }
        public Store(string name, Guid storeIdGuid)
        {
            Name = name;
            IdGuid = storeIdGuid;
        }

        public string Name { get; private set; }
        public Guid IdGuid { get; private set; }

        public bool Validate()
        {
            if (Name == null || Name == "")
                return false;

            return true;
        }

    }
}
