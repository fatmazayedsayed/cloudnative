using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structure_Decode
{
	public class LinkedList
	{
		public LinkedListNode head = null;
		public LinkedListNode tail = null;//pointer to the tail

LinkedListIterator begin()
		{
			LinkedListIterator itr = new LinkedListIterator(head);

			return itr;
		}		
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
		public void InsertBefore(LinkedListNode node, int _data)
		{
			LinkedListNode newNode = new LinkedListNode(_data);

			newNode.next = node;
			//find parent
			LinkedListNode parent=FindParent( node);
			if(parent==null)
			{
				head = newNode;
			}
			else
			{
				parent.next = newNode;
			}

		}


		public void InsertAfter(LinkedListNode node, int _data)
		{
			LinkedListNode newNode = new LinkedListNode(_data);
			newNode.next = node.next;
			node.next = newNode;
			if (tail == node)
			{
				tail = newNode;

			}

		}
		public void InsertAfter(int value, int _data)
		{
			LinkedListNode newNode = new LinkedListNode(_data);

			LinkedListNode node = new LinkedListNode(value);

			for (LinkedListIterator itr = begin(); itr.current() != null; itr.next())
			{
				if (itr.data() == value)
				{
					node= itr.current();
					break;
				}
			}

			newNode.next = node.next;
			node.next = newNode;
			if (tail == node)
			{
				tail = newNode;
			}
		}



		public void DeleteNode(LinkedListNode node)
		{
			if (head == tail)
			{
				//only one item in the list
				head = null;
				tail = null;
			}
			else if(head==node)
				{
					//delete first item
					head = node.next;
				}
			else
			{
				//middle node
				//find the parent

				LinkedListNode parent = FindParent(node);
				if(tail==node)
				{
					//delete last node
					tail = parent;
				}
				else
				{
					//in middel
					parent.next = node.next;
				}
			}

		}


		private LinkedListNode FindParent(LinkedListNode node)
		{
			for (LinkedListIterator itr = begin(); itr.current() != null; itr.next())
			{
				if (itr.current().next == node)
				{
					return itr.current();
				}

			}
			return null;
		}
		public LinkedListNode FindData(int _data)
		{
			for (LinkedListIterator itr = begin(); itr.current() != null; itr.next())
			{
				if(itr.data()==_data)
				{
					return itr.current();
				}
				 
			}
			return null;

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
