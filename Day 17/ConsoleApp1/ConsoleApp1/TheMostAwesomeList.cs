using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TheMostAwesomeList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        // methods for our linked list// 

        // create the add function 
        public void Add (string input)
        {
            Node newNode = new Node { Next = null, Data = input };
            // first we check to see if the count is zero, confirm how many nodes are in the list
            if (Count == 0)
            {
                
                Head = newNode;
                Tail = newNode; 

            }
            else // if something is alreaady there we need to change Next
            {
                Tail.Next = newNode; // not yet set to tail , at the moment it is tail.next
                Tail = newNode; // now the tail and set as the tail to be called that way. 
            }
            Count++; // need to adjust the count for every new node. it does not count for us. 
        }
        public Node GetNode(int index) // we need to CREATE a method to ACCESS a node based off an index
        {
            // we need to create another variable for our START
            int start = 0;
            Node temp = Head; // marks the start of our search becasue we are starting at the head.
            // we will use a while loop to go through the node until the start = the index.
            // if start = index return temp, if it does not then we will add 1 to start &  temp = temp.next to look at the next node
            while (start != index)
            {
                start++;
                temp = temp.Next;
                // temp matches start 
            }
            return temp;
        }

        public void RemoveNode(int index)
        {
           
            if(index != 0) //possible if(index == 0)
            {
                Node temp = GetNode(index - 1); // Head.Head.Next
                if(temp.Next == Tail) // taking into account the tail now
                {
                    Tail = temp;
                    temp.Next = null;
                }
                else
                {
                    temp.Next = GetNode(index + 1);

                }

            }
            else
            {
                Head = Head.Next; // Node thisNode = GetNode(index-1)
                                        // if(thisNode.Next.Next != null)
                                            // thisNode.Next = thisNode.Next.Next;
                                        // else Tail = thisNode.Next; you want to account for the tail 
            }
            Count--; 
        }
    }
}
