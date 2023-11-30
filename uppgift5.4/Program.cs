using System;
namespace uppgift5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnArray = { "Kevin", "Bert", "Stina", "Alfred", "Moa" };
            Array.Sort(namnArray);
            foreach(string namn in namnArray)
            {
                Console.WriteLine(namn);
            }
        }
    }
}