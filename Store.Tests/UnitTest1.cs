using store.api;
using StoreModel = Store.Api.Store;

namespace Store.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Validate_When_Store_With_Null_Name_Should_Return_False_Using_Fact()
        {
            var store = new StoreModel(1, null, Guid.NewGuid());
            var result = store.Validate();

            Assert.False(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Validate_When_Store_With_Null_Name_Should_Return_False_Using_Theory(String storeName)
        {
            var store = new StoreModel(1, storeName, Guid.NewGuid());
            var result = store.Validate();

            Assert.False(result);
        }

        [Fact]
        public void Validate_When_Store_With_Valid_Name_Should_Return_True_Using_Fact()
        {
            var store = new StoreModel(1, "Loja teste", Guid.NewGuid());
            var result = store.Validate();

            Assert.True(result);

        }

        [Theory]
        [InlineData("Hamburgueria de batatas")]
        [InlineData("Taco Belo")]
        [InlineData("Olive Jardim")]
        public void Validate_When_Store_With_Valid_Name_Should_Return_True_Using_Theory(String storeName)
        {
            var store = new StoreModel(1, storeName, Guid.NewGuid());
            var result = store.Validate();

            Assert.True(result);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("Hamburgueria de batatas", true)]
        public void Validate_Store_Name(String storeName, bool expectedResult)
        {
            var store = new StoreModel(1, storeName, Guid.NewGuid());
            var result = store.Validate();

            Assert.Equal(expectedResult,result);
        }
    }
}