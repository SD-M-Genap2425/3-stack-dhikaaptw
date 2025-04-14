using System;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data { get; set; }
            public Node Next { get; set; }

            public Node(char data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public bool ValidasiEkspresi(string ekspresi)
        {
            top = null;
            foreach (char c in ekspresi) {
                if (c == '(' || c == '{' || c == '[') {
                    Node newNode = new Node(c);
                    newNode.Next = top;
                    top = newNode;
                }
                else if (c == ')' || c == '}' || c == ']') {
                    if (top == null) {
                        return false;
                    }

                    char opening = top.Data;
                    top = top.Next;

                    if (!IsMatchingPair(opening, c)) {
                        return false;
                    }
                }
            }

            return top == null;
        }

        private bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') || (opening == '{' && closing == '}') || (opening == '[' && closing == ']');
        }
    }
}
