namespace OpenClosed.Model
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}