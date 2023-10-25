using Microsoft.AspNetCore.Mvc;

namespace DevopsWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomNumberGeneratorController : ControllerBase
    { 

        [HttpGet("random")]
        public uint Get()
        {
            return new RandomNumberGenerator().RandomNumber;
        }

        [HttpGet("random/{upperLimit}")]
        public uint Get(uint upperLimit)
        {
            return upperLimit +  new RandomNumberGenerator(upperLimit).RandomNumber;
        }

        [HttpGet("random/{lowerLimit}&{upperLimit}")]
        public uint Get(uint lowerLimit, uint upperLimit)
        {
            return upperLimit + new RandomNumberGenerator(lowerLimit, upperLimit).RandomNumber;
        }
    }
}