using DevopsWebApp.Controllers;

namespace DevopsWebApp.Test
{
    public class RandomNumberGeneratorControllerTest
    {
        readonly RandomNumberGeneratorController _controller;

        public RandomNumberGeneratorControllerTest()
        { 
            _controller = new RandomNumberGeneratorController();
        }

        [Fact]
        public void Get_Random_Number()
        {
            //Arrange

            //Act
            var randomNumber = _controller.Get();

            //Assert
            Assert.IsType<uint>(randomNumber);
            Assert.InRange<uint>(randomNumber, 0, Int32.MaxValue);
        }

        [Fact]
        public void Get_Random_UpperLimit()
        {
            //Arrange
            uint upperLimit = 50;

            //Act
            var randomNumber = _controller.Get(upperLimit);

            //Assert
            Assert.IsType<uint>(randomNumber);
            Assert.InRange<uint>(randomNumber, 0, upperLimit);
        }

        [Fact]
        public void Get_Random_LowerUpperLimit()
        {
            //Arrange
            uint lowerLimit = 50;
            uint upperLimit = 200;

            //Act
            var randomNumber = _controller.Get(lowerLimit, upperLimit);

            //Assert
            Assert.IsType<uint>(randomNumber);
            Assert.InRange<uint>(randomNumber, lowerLimit, upperLimit);
        }
    }
}