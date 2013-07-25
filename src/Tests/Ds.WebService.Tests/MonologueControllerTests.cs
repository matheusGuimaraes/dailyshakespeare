using Ds.WebService.Controllers;
using NUnit.Framework;

namespace Ds.WebService.Tests
{
    [TestFixture]
    public class MonologueControllerTests
    {
        private MonologueController _controller;

        [SetUp]
        public void Init()
        {
            _controller = new MonologueController();
        }

        [Test]
        public void Should_get_a_monologue()
        {
            var result = _controller.Get();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id != 0);
        }
    }
}
