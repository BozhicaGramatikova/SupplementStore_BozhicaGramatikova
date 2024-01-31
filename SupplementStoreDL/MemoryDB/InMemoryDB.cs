using SupplementStoreModels.Models;

namespace SupplementStoreDL.MemoryDB
{
    public static class InMemoryDb
    {
        public static List<Store> Stores = new List<Store>()
        {
            new Store()
            {
                Id = 1,
                Name = "SilaBg",
                BirthDay = DateTime.Now
            },
              new Store()
            {
                Id = 2,
                Name = "Bodybuilding.com",
                BirthDay = DateTime.Now
            },
                new Store()
            {
                Id = 3,
                Name = "Myprotein",
                BirthDay = DateTime.Now
            }
        };

        public static List<Supplement> Supplements = new List<Supplement>()
        {
            new Supplement()
            {
                Id = 1,
                Name = "Protein",
                StoreId = 2
            },
            new Supplement()
            {
                Id = 2,
                Name = "Creatine",
                StoreId = 3
            },
            new Supplement()
            {
                Id = 3,
                Name = "BCAA",
                StoreId = 3
            }
        };
    }
}
