using Ds.WebService.Repositories;
using NUnit.Framework;

namespace Ds.WebService.Tests.Repositories
{
    [TestFixture]
    public class MonologueRepositoryTests
    {
        private MonologueRepository _monologueRepository;

        [SetUp]
        public void Init()
        {
            _monologueRepository = new MonologueRepository();
        }

        [Test]
        public void Should_get_a_random_monologue()
        {
            var result = _monologueRepository.GetRandom();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id != 0);
        }
    }
}
