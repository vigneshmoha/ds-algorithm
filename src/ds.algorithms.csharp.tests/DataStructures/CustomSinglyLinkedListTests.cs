using ds.algorithms.csharp.DataStructures;
using Xunit;
using System;

namespace ds.algorithms.csharp.tests.DataStructures
{
    public class CustomSinglyLinkedListTests
    {
        [Fact]
        public void CustomSinglyLinkedList_CreationLinkedListValidate()
        {
            var linkedList = new CustomSinglyLinkedList<int>();
            Assert.Null(linkedList.Head);
            Assert.Null(linkedList.CurrentNode);

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            Assert.True(linkedList.Head.Data == 1);
            Assert.Equal(linkedList.Head.Data.ToString(), linkedList.CurrentNode.Data.ToString());

            linkedList.MoveToNext();

            Assert.NotSame(linkedList.CurrentNode, linkedList.Head);
            Assert.Equal("2", linkedList.CurrentNode.Data.ToString());

            linkedList.MoveToNext();
            Assert.Throws<Exception>(() => linkedList.MoveToNext());
        }

        //Todo: Add more tests to improve code coverage
    }
}
