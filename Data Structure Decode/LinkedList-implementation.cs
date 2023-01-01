using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Decode
{
	public class LinkedList
	{
		public LinkedListNode head = null;
		public LinkedListNode tail = null;//pointer to the tail


		public void InsertLast(int _data)
		{
			LinkedListNode newNode = new LinkedListNode(_data);
			if (head == null)
			{
				//list is empty
				head = newNode;
				tail = newNode;
			}
			else
			{
				tail.next = newNode;
				tail = newNode;
			}

		}
		LinkedListIterator begin()
		{
			LinkedListIterator itr = new LinkedListIterator(head);

			return itr;
		}
		public void PrintList()
		{
			for (LinkedListIterator itr = begin(); itr.current() != null; itr.next())
			{
				Console.WriteLine(itr.data());
			}
		}

	}

	public class LinkedListNode
	{
		public int data;
		public LinkedListNode next;
		public LinkedListNode(int _data)
		{
			data = _data;
			next = null;
		}

	}

	public class LinkedListIterator
	{
		LinkedListNode currentNode;
		public LinkedListIterator()
		{
			currentNode = null;
		}
		public LinkedListIterator(LinkedListNode node)
		{
			currentNode = node;
		}

		public int data()
		{
			return currentNode.data;
		}
		public LinkedListIterator next()
		{
			currentNode = currentNode.next;
			return this;
		}
		public LinkedListNode current()
		{
			return currentNode;
		}
	}

}
