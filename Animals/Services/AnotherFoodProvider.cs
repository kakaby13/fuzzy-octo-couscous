using Animals.Models;

namespace Animals.Services;

public class AnotherFoodProvider : IFoodProvider
{
    public Food GetFood()
    {
        Console.WriteLine("another food provided");

        return new Food
        {
            Satiety = 42
        };
    }
}