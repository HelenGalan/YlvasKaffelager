namespace YlvasKaffelager.Models
{
    public interface ICalcPrice
    {
        decimal GetTotal(decimal price, decimal amount);
    }
}