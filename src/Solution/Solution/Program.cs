using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        Browser browser = new Browser();
        browser.KunjungiHalaman("google.com");
        browser.KunjungiHalaman("example.com");
        browser.KunjungiHalaman("stackoverflow.com");
        browser.LihatHalamanSaatIni();
        browser.Kembali();
        browser.LihatHalamanSaatIni();
        browser.TampilkanHistory();
        
        // Bracket validator
        var validator = new BracketValidator();
        Console.WriteLine($"Ekspresi '[](){{}}' valid? {validator.ValidasiEkspresi("[{}](){}")}");
        Console.WriteLine($"Ekspresi '(]' valid? {validator.ValidasiEkspresi("")}");
        
        //Palindrome Checker
        Console.WriteLine(PalindromeChecker.CekPalindrom("Kasur ini rusak"));
        Console.WriteLine(PalindromeChecker.CekPalindrom("Ibu Ratna antar ubi"));
        Console.WriteLine(PalindromeChecker.CekPalindrom("Hello World"));
        

    }
}
