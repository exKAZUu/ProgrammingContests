using System;
using System.IO;

namespace UPLC2013 {
    internal class ProblemB {
        //private static void Main(string[] args) {
        //    new ProblemB().Solve(Console.In);
        //}

        private void Solve(TextReader reader) {
            while (true) {
                var str = reader.ReadLine().Trim();
                if (str == "-") {
                    break;
                }
                var nShuffles = int.Parse(reader.ReadLine().Trim());
                var index = 0;
                for (int iShuffles = 0; iShuffles < nShuffles; iShuffles++) {
                    index += int.Parse(reader.ReadLine().Trim());
                }
                index = index % str.Length;
                Console.WriteLine(str.Substring(index) + str.Substring(0, index));
            }
        }
    }
}