namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText =  "Toto je retezec predstavovany nekolika radky,\n"
                             + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                             + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                             + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                             + "posledni veta!";
            Console.WriteLine(testText);
            Console.WriteLine();

            StringStatistics s = new StringStatistics(testText);
            Console.WriteLine("Number of words: {0}", s.NumberOfWords());
            Console.WriteLine("Number of rows: {0}", s.NumberOfRow());
            Console.WriteLine("Number of sentences: {0}", s.NumberOfSentences());
            Console.WriteLine("Longest words: {0}", s.PrintArrayList(s.LongestWords()));
            Console.WriteLine("Shortest words: {0}", s.PrintArrayList(s.ShortestWords()));
            Console.WriteLine("Most common words: {0}", s.PrintArrayList(s.MostCommonWords()));
            Console.WriteLine("Sorted words: {0}", s.PrintArrayList(s.SortedArray()));
            Console.ReadLine();
        }
    }
}