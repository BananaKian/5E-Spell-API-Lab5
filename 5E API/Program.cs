using System.Text.Json;
using static System.Console;
using _5E_API.Service;
using _5E_API.Data;


namespace _5E_API
{
    public class Program
    {
        static async Task Main(string[] args)
        {
           FifthEAPIService SpellFinder = new ();

            string acidArrow = "acid-arrow";

            WriteLine("Insert a spell name you'd like to look up. For format, use all lowercase and use - in place of spaces.\n");
            string indx = ReadLine();
            WriteLine("\n");

           await SpellFinder.GetSpell(indx);
 
        }
    }
}