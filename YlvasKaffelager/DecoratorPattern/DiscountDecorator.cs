using YlvasKaffelager.Models;

namespace YlvasKaffelager.DecoratorPattern
{
    public class DiscountDecorator : BaseDecorator
    {
        public DiscountDecorator(ICalcPrice calcPrice) : base(calcPrice)
        {
        }

        public override decimal GetTotal(decimal amount, decimal price)
        {
            decimal total = 0;
            decimal premiumDiscount = 0.80m; //20% discount
            decimal basicDiscount = 0.95m; //5% discount

            if (amount < 20 && amount >= 5)
            {
                total = (amount * price) * premiumDiscount;
            }
            else if (amount >= 20)
            {
                total = (amount * price * basicDiscount);
            }
            else
            {
                total = amount * price;
            }

            return total;
        }
    }
}
