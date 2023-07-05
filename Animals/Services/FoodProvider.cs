using Animals.Models;

namespace Animals.Services;

public class FoodProvider : IFoodProvider
{
    public Food GetFood()
    {
        Console.WriteLine("food provided");

        return new Food
        {
            Satiety = 42
        };
    }
}