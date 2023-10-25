namespace DevopsWebApp.Test
{
    public class RandomNumberGeneratorControllerTest
    {

        [Fact]
        public void Get_Random_Number()
        {
            //Arrange

            //Act
            var randomNumberGenerator = new RandomNumberGenerator();
            var randomNumber = randomNumberGenerator.RandomNumber;

            //Assert
            Assert.NotNull(randomNumberGenerator);
            Assert.IsType<uint>(randomNumber);
            Assert.InRange<uint>(randomNumber, 0, Int32.MaxValue);
        }

        [Fact]
        public void Get_Random_UpperLimit()
        {
            //Arrange
            uint upperLimit = 50;

            //Act
            var randomNumberGenerator = new RandomNumberGenerator(upperLimit);
            var randomNumber = randomNumberGenerator.RandomNumber;

            //Assert
            Assert.NotNull(randomNumberGenerator);
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
            var randomNumberGenerator = new RandomNumberGenerator(lowerLimit, upperLimit);
            var randomNumber = randomNumberGenerator.RandomNumber;

            //Assert
            Assert.NotNull(randomNumberGenerator);
            Assert.IsType<uint>(randomNumber);
            Assert.InRange<uint>(randomNumber, lowerLimit, upperLimit);
        }
    }
}