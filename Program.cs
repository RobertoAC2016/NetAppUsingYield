namespace NetAppUsingYield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Consultemos cada metodo

            foreach (var line in ReadLog.ReadLogFile("log.txt"))
            {
                Console.WriteLine(line);
            }


            foreach (var line in ReadLog.ReadLogLinesRightWay("log.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
