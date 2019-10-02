using System;

namespace ds.algorithms.csharp.DataStructures
{
    public class CustomSinglyLinkedList<T>
    {
        public SinglyNode<T> Head;

        public SinglyNode<T> CurrentNode;

        public void AddFirst(T data)
        {
            var newNode = new SinglyNode<T>(data);
            
            if(Head == null)
            {
                Head = newNode;
                CurrentNode = Head;
            }

            newNode.Next = Head.Next;
        }

        public void AddNodeAfter(SinglyNode<T> prevNode, T data)
        {
            var newNode = new SinglyNode<T>(data);
            var temp = prevNode.Next;
            prevNode.Next = newNode;
            newNode.Next = temp;
        }

        public void AddLast(T data)
        {
            var newNode = new SinglyNode<T>(data);

            if(Head == null)
            {
                Head = newNode;
                CurrentNode = Head;
                return;
            }

            var lastNode = GetTailNode();
            lastNode.Next = newNode;
        }

        public SinglyNode<T> GetTailNode()
        {
            var currentNode = Head;
            while(currentNode != null && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void RemoveNodeByData(T inputData)
        {
            var temp = Head;
            if (temp == null)
            {
                throw new ArgumentNullException("Linked list is empty. Cannot perform remove operations");
            }

            if(temp.Data.Equals(inputData))
            {
                Head = temp.Next;
                return;
            }

            SinglyNode<T> prevNode = null;
            while(temp != null && !temp.Data.Equals(inputData))
            {
                prevNode = temp;
                temp = temp.Next;
            }

            if(temp == null)
            {
                throw new ArgumentNullException("Key not found. Nothing was removed from linked list");
            }

            prevNode.Next = temp.Next;
        }

        public void MoveToNext()
        {
            if(CurrentNode.Next == null)
            {
                throw new Exception($"Current Node is already at the end of the linked lists");
            }

            CurrentNode = CurrentNode.Next;
        }

        public void ResetCurrentPointer()
        {
            CurrentNode = Head;
        }
    }

    public sealed class SinglyNode<T>
    {
        public T Data;
        public SinglyNode<T> Next;

        public SinglyNode(T value)
        {
            Data = value;
            Next = null;
        }
    }
}
