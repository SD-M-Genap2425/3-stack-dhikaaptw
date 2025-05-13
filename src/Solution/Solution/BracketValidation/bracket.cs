using System;

namespace Solution.BracketValidation
{
    public class Node
    {
        public char? Data;
        public Node? Next;
        public Node(char Data)
        {
            this.Data = Data;
            Next = null;
        }
    }
    public class BracketValidator
    {
        private Node? top;
        public BracketValidator()
        {
            top = null;
        }
        private void Push(char ch)
        {
            Node newNode = new Node(ch);
            newNode.Next = top;
            top = newNode;
        }
        
        private char? Pop()
        {
            if (top == null)
                return null;
            
            char? data = top.Data;
            top = top.Next;
            return data;
        }
        
        private char? Peek()
        {
            return top?.Data;
        }
        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char? topChar = Pop();
                    if (topChar == null || !IsMatchingPair(topChar.Value, ch))
                    {
                        return false;
                    }
                }
            }
            
            return top == null;
        }
        private bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                (open == '{' && close == '}') ||
                (open == '[' && close == ']');
        }
    }
}   