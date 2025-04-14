namespace Solution.BrowserHistory
{

    public class Halaman
    {
        public string URL { get; set; }

        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class BrowserHistory
    {
        private class Node
        {
            public Halaman Data { get; set; }
            public Node Next { get; set; }

            public Node(Halaman data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public void KunjungiHalaman(string url)
        {
            Halaman halaman = new Halaman(url);
            Node newNode = new Node(halaman);
            newNode.Next = top;
            top = newNode;
        }

        public string Kembali()
        {
            if (top == null || top.Next == null) {
                return null;
            }

            string currentUrl = top.Data.URL;
            top = top.Next;
            return currentUrl;
        }

        public string LihatHalamanSaatIni()
        {
            return top?.Data.URL;
        }

        public void TampilkanHistory()
        {
            if (top == null) {
                Console.WriteLine("History kosong.");
                return;
            }

            Node current = top;
            int index = 1;
            while (current != null) {
                Console.WriteLine($"{index}. {current.Data.URL}");
                current = current.Next;
                index++;
            }
        }
    }
}