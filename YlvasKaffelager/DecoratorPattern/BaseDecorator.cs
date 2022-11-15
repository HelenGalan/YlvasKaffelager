using YlvasKaffelager.Models;

namespace YlvasKaffelager.DecoratorPattern
{
    public class BaseDecorator : ICalcPrice
    {
        ICalcPrice _calcPrice;

        public BaseDecorator(ICalcPrice calcPrice)
        {
            _calcPrice = calcPrice;
        }
        public virtual decimal GetTotal(decimal price, decimal amount)
        {
            return _calcPrice.GetTotal(price, amount);
        }
    }
}
