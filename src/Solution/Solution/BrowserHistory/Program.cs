using System;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; set; }
        public Halaman(string url) => URL = url;
    }

    public class Node
    {
        public Halaman Data;
        public Node Next;
        public Node(Halaman data) => Data = data;
    }

    public class StackManual
    {
        private Node top;

        public void Push(Halaman data)
        {
            Node newNode = new Node(data) { Next = top };
            top = newNode;
        }

        public Halaman Pop()
        {
            if (top == null) {
                return null;
            }
            
            Halaman popped = top.Data;
            top = top.Next;
            return popped;
        }

        public Halaman Peek() => top?.Data;

        public bool IsEmpty() => top == null;

        public void PrintHistory()
        {
            Node current = top;
            int count = 1;
            while (current != null)
            {
                Console.WriteLine($"{count++}. {current.Data.URL}");
                current = current.Next;
            }
        }
    }

    public class Browser
    {
        private StackManual history = new StackManual();

        public void KunjungiHalaman(string url)
        {
            Console.WriteLine($"Mengunjungi halaman: {url}");
            history.Push(new Halaman(url));
        }

        public void Kembali()
        {
            if (!history.IsEmpty())
            {
                history.Pop();
                Console.WriteLine("Kembali ke halaman sebelumnya...");
            }
        }

        public void LihatHalamanSaatIni()
        {
            var halaman = history.Peek();
            Console.WriteLine("Halaman saat ini: " + (halaman?.URL ?? "Tidak ada halaman"));
        }

        public void TampilkanHistory()
        {
            Console.WriteLine("Menampilkan history:");
            history.PrintHistory();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Browser browser = new Browser();
            browser.KunjungiHalaman("google.com");
            browser.KunjungiHalaman("example.com");
            browser.KunjungiHalaman("stackoverflow.com");
            browser.LihatHalamanSaatIni();
            browser.Kembali();
            browser.LihatHalamanSaatIni();
            browser.TampilkanHistory();
        }
    }
}