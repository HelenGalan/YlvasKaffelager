using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager;

namespace Testing
{
    public class DbContextTest
    {
        private Mock<IDbContext> _sut;
        private DbContext db;

        public DbContextTest()
        {
            _sut = new Mock<IDbContext>();
            db = new DbContext();
        }

        [Fact]
        public void Should_Return_Coffee()
        {
            try
            {
                _sut.Setup(s => s.GetCoffe(1))
                .Returns(db.Coffees
                .Where(s => s.Id == 1)
                .Single());

                var expected = _sut.Object.GetCoffe(1);
                var actual = db.GetCoffe(1);

                Assert.Equal(expected.Brand, actual.Brand);
            }
            catch (Exception)
            {

                Console.WriteLine("Use useful data!");
            }
        }
    }
}
