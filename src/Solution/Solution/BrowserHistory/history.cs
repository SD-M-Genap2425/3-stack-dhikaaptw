using System;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string? URL{get;}
        public Halaman(string URL)
        {
            this.URL = URL;
        }
    }

    public class Node
    {
        public Halaman? Data;
        public Node? Next;
        public Node(Halaman Data)
        {
            this.Data = Data;
            this.Next = null;
        }
    }
    public class HistoryManager
    {
        private Node? top;
        public HistoryManager()
        {
            top = null;
        }
        public string LihatHalamanSaatIni()
        {
            if(top == null)
            {
                Console.WriteLine("Tidak ada halaman yang sedang dikunjungi.");
                return null!;
            }
            return top.Data!.URL!;
        }
        public void KunjungiHalaman(string URL)
        {
            Node newNode = new Node(new Halaman(URL));
            newNode.Next = top;
            top = newNode;
            System.Console.WriteLine($"Mengunjungi halaman: {URL}");
        }
        public string Kembali()
        {
            if(top == null || top.Next == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            top = top.Next;
            System.Console.WriteLine("Kembali ke halaman sebelumnya...");
            return top.Data!.URL!;
        }
                public void TampilkanHistory()
        {
            if (top == null)
            {
                Console.WriteLine("History browser kosong.");
                return;
            }
            var stack = new Stack<string>();
            var current = top;
            while (current != null)
            {
                stack.Push(current.Data!.URL!);
                current = current.Next;
            }
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}