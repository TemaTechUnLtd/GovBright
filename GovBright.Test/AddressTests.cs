namespace GovBright.Test
{
    using GovBright.Web.Exceptions;
    using GovBright.Web.Services;
    using Moq;

    public class AddressTests
    {
        [Fact]
        public async Task SearchAddress_ReturnsCollection()
        {
            //arrange
            var addressClientHelper = new Mock<IAddressClientHelper>();
            addressClientHelper.Setup(a => a.GetAddressesAsync(It.IsAny<string>()))
                .ReturnsAsync(new List<string>
                {
                    "addrees record 1",
                    "addrees record 2",
                    "addrees record 3",
                    "addrees record 4"
                });

            var addressservice = new AddressService(addressClientHelper.Object);

            //act
           var addresses = await addressservice.SearchAddress("po1 1AX");

            //assert
            Assert.NotEmpty(addresses);
        }

        [Fact]
        public async Task SearchAddress_ReturnsEmptyCollection()
        {
            //arrange
            var addressClientHelper = new Mock<IAddressClientHelper>();
            addressClientHelper.Setup(a => a.GetAddressesAsync(It.IsAny<string>()))
                .ReturnsAsync(new List<string>());

            var addressservice = new AddressService(addressClientHelper.Object);

            //act
            var addresses = await addressservice.SearchAddress("po1 1AX");

            //assert
            Assert.Empty(addresses);
        }

        [Fact]
        public async Task SearchAddress_ThrowsError()
        {
            //arrange
            var addressClientHelper = new Mock<IAddressClientHelper>();
            addressClientHelper.Setup(a => a.GetAddressesAsync(It.IsAny<string>()))
                .Throws<AddressException>();

            var addressservice = new AddressService(addressClientHelper.Object);

            //act
            Func<Task> act = () => addressservice.SearchAddress("po1 1AX");

            //assert
            var exception = await Assert.ThrowsAsync<AddressException>(act);
        }
    }
}
