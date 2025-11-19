using Lab11.Models;

namespace Lab11.Services
{
    public class GetDataService : IGetData
    {
        private readonly Random _random = new();
        public NumbersOperations Generate()
        {
            return new NumbersOperations
            {
                FirstNumber = _random.Next(0, 11),
                SecondNumber = _random.Next(0, 11)
            };
        }
    }
}