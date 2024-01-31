using Moq;
using SupplementStoreBL.Services;
using SupplementStoreDL.Interfaces;
using SupplementStoreDL.Repositories;
using SupplementStoreModels.Models;

namespace SupplementStoreTests
{
    public class LibraryServiceTests


    {
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
        [Fact]
        public void CheckSupplementCount_OK()
        {
            var input = 10;
            var expectedCount = 12;

            var repository = new Mock<ISupplementRepository>();

            repository.Setup(
                x=>x.GetAll())
                .Returns(Supplements);

            var supplementService = new SupplementService(repository.Object);
            var storeService = new StoreService(new StoreRepository());
            var service = new BrandService(storeService, supplementService);

            var result = service.CheckStoreCount(input);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckStoreCount_Negative()
        {
            var input = 10;
            var expectedCount = 13;

            var repository = new Mock<IStoreRepository>();

            repository.Setup(
                x => x.GetAll())
                .Returns(Stores);

            var supplementService = new SupplementService(new SupplementRepository());
            var storeService = new StoreService( repository.Object);
            var service = new BrandService(storeService, supplementService);

            var result = service.CheckStoreCount(input);

            Assert.Equal(expectedCount, result);

        }
    }
}



