namespace DevopsWebApp
{
    public class RandomNumberGenerator
    {
        public uint LowerLimit { get; set; } = 0;

        public uint UpperLimit { get; set; } = Int32.MaxValue;

        public uint RandomNumber => (uint)(LowerLimit + new Random().Next() % (UpperLimit - LowerLimit));

        public RandomNumberGenerator() { }
        
        public RandomNumberGenerator(uint upperLimit)
        {
            UpperLimit = upperLimit;
        }

        public RandomNumberGenerator(uint lowerLimit, uint upperLimit)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

    }
}