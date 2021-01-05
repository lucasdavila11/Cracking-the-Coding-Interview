using System;
namespace CrackingCodingInterview.Core
{
    public class BinaryNode
    {
        public int Value { get; set; }

        public BinaryNode Left { get; set; }

        public BinaryNode Right { get; set; }

        public BinaryNode() { }

        public BinaryNode(int value)
        {
            Value = value;
        }
    }
}
