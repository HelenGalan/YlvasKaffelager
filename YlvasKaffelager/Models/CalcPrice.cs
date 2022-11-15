namespace YlvasKaffelager.Models
{
    public class CalcPrice : ICalcPrice
    {
        public decimal GetTotal(decimal price, decimal amount)
        {
            return price * amount;
        }
    }
}
