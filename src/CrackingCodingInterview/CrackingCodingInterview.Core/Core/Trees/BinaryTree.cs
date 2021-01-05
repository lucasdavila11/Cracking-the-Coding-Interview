using System;
namespace CrackingCodingInterview.Core
{
    public class BinaryTree
    {
        public BinaryNode Root { get; set; }

        public BinaryTree(int value)
        {
            Root = new BinaryNode()
            {
                Value = value
            };
        }

        public void AddNode(int value)
        {
            var current = Root;

            while(current != null)
            {
                if(current.Left != null && current.Right != null)
                {
                    //check the left branch , check the right branch
                    if(current.Left.Left == null || current.Left.Right == null)
                    {
                        current = current.Left;
                    }
                    else if(current.Right.Left == null || current.Right.Right == null)
                    {
                        current = current.Right;
                    }
                }
                else if(current.Left == null)
                {
                    current = current.Left;
                }
                else if(current.Right == null)
                {
                    current = current.Right;
                }
            }

            current = new BinaryNode(value);
        }


        public static void InOrder(BinaryNode node)
        {
            var current = node;
            if(current != null)
            {
                Console.WriteLine("{0} ", current.Value);
                InOrder(current.Left);
                InOrder(current.Right);
            }
            
        }
    }
}
