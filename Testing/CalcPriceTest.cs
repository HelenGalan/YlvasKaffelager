using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager.Models;

namespace Testing
{
    public class CalcPriceTest
    {
        private CalcPrice _sut;

        public CalcPriceTest()
        {
            _sut = new CalcPrice();
        }

        [Fact]
        public void Should_Return_Correct_Sum()
        {
            decimal amount = 5;
            decimal price = 30;

            var expected = 150;
            var actual = _sut.GetTotal(price, amount);

            Assert.Equal(expected, actual);
        }

    }
}
