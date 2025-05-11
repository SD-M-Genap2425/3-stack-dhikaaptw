namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data;
            public Node Next;
            public Node(char data) => Data = data;
        }

        private Node top;

        private void Push(char c) => top = new Node(c) { Next = top };

        private char? Pop()
        {
            if (top == null) return null;
            char data = top.Data;
            top = top.Next;
            return data;
        }

        private bool IsEmpty() => top == null;

        public bool ValidasiEkspresi(string ekspresi)
        {
            top = null; // reset stack
            foreach (char c in ekspresi)
            {
                if (c == '(' || c == '{' || c == '[')
                    Push(c);
                else if (c == ')' || c == '}' || c == ']')
                {
                    char? popped = Pop();
                    if (popped == null ||
                        (c == ')' && popped != '(') ||
                        (c == '}' && popped != '{') ||
                        (c == ']' && popped != '['))
                        return false;
                }
            }
            return IsEmpty();
        }
    }
}