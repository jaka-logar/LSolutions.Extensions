using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LSolutions.Extensions.Tests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void IsEmptyTest()
        {
            IList<int> list = null;
            Assert.True(list.IsNullOrEmpty());

            list = new List<int>();
            Assert.True(list.IsNullOrEmpty());

            list = new List<int>
            {
                1,2,3
            };
            Assert.False(list.IsNullOrEmpty());
        }

        [Fact]
        public void DistinctByTest()
        {
            IList<int> list = new List<int>
            {
                1,1,1,2,2,2,3,3,3
            };

            IEnumerable<int> distinctList = list.DistinctBy(x => x);
            Assert.True(distinctList.Count() == 3);
        }

        [Fact]
        public void BatchTest()
        {
            IList<int> list = new List<int>
            {
                1,1,1,1,2,2,2,2,3,3,3,3
            };

            IEnumerable<IEnumerable<int>> batchResult = list.Batch(4);

            Assert.True(batchResult.Count() == 3);

            Assert.All(batchResult, x => Assert.True(x.Distinct().Count() == 1));
        }
    }
}
