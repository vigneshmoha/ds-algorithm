using ds.algorithms.csharp.DataStructures;
using Xunit;

namespace ds.algorithms.csharp.tests
{
    public class CustomListTests
    {
        [Fact]
        public void CustomLists_ValidateListCount()
        {
            var listObj = new CustomList<int>();

            Assert.True(listObj.Count == 0);

            listObj.Add(2);
            listObj.Add(3);
            listObj.Add(6);
            listObj.Add(2);
            listObj.Add(3);
            listObj.Add(6);

            Assert.True(listObj.Count == 6);
        }

        [Fact]
        public void CustomLists_ValidateClearMethod()
        {
            var listObj = new CustomList<int>();
            listObj.Add(2);
            listObj.Add(3);
            listObj.Add(6);

            Assert.True(listObj.Count == 3);

            listObj.Clear();

            Assert.True(listObj.Count == 0);
        }

        [Fact]
        public void CustomLists_ValidateRemoveMethod()
        {
            var listObj = new CustomList<int>();
            listObj.Add(2);
            listObj.Add(3);
            listObj.Add(6);

            Assert.True(listObj.Remove(3));
            Assert.True(listObj.Count == 2);
            Assert.True(listObj[1] == 6);

            Assert.False(listObj.Remove(5));
        }
    }
}
