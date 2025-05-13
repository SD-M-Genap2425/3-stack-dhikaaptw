using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        var historyManager = new HistoryManager();
            historyManager.KunjungiHalaman("google.com");
            historyManager.KunjungiHalaman("example.com");
        var historyManager1 = new HistoryManager();
            historyManager1.KunjungiHalaman("google.com");
            historyManager1.KunjungiHalaman("example.com");
            var previousPage = historyManager1.Kembali();
        
        // Bracket validator
        var validator = new BracketValidator();
        var expression = "{[()]}";
        bool isValid = validator.ValidasiEkspresi(expression);

        

        //Palindrome Checker
        var input = "Kasur ini rusak";
        var result = PalindromeChecker.CekPalindrom(input);


    }
}
