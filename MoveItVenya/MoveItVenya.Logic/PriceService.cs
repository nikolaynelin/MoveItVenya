using System;

namespace MoveItVenya.Logic
{
    public interface IPriceService
    {
        decimal Calculate(double p1, double p2, double d3);
    }

    public class PriceService : IPriceService
    {
        public decimal Calculate(double p1, double p2, double d3)
        {
            return (decimal)new Random().NextDouble();
        }
    }
}
