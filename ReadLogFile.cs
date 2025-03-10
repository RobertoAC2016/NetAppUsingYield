using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAppUsingYield
{
    static class ReadLog
    {
        /// <summary>
        /// Esta es la forma en la que no se deberia hacer
        /// en este ejemplo se utiliza demasiada memoria cuando el log es muy 
        /// extenso o que excede la capacidad de memoria del host
        /// </summary>
        /// <param name="StringPath"></param>
        /// <returns></returns>
        public static List<String> ReadLogFile(String StringPath)
        {
            var lines = new List<string>();
            foreach (var line in File.ReadAllLines(StringPath))
            {
                if (!string.IsNullOrEmpty(line)) lines.Add(line);
            }
            return lines;
        }
        /// <summary>
        /// Esta es la mejor forma de optimizar los recursos de memoria del host
        /// </summary>
        /// <param name="StringPath"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLogLinesRightWay(String StringPath)
        {
            foreach (var line in File.ReadLines(StringPath))
            {
                if (!string.IsNullOrEmpty(line)) yield return line;
            }
        }

    }
}
