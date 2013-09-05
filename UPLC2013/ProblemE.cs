using System;
using System.IO;
using System.Linq;

namespace UPLC2013 {
    internal class ProblemE {
        //private static void Main(string[] args) {
        //    new ProblemE().Solve(Console.In);
        //}

        private void Solve(TextReader reader) {
            while (true) {
                var str = reader.ReadLine();
                if (str == null) {
                    return;
                }
                var n = int.Parse(str);
                Console.WriteLine((1 + n) * n / 2 + 1);
            }
        }
    }
}