using System;
using System.IO;

namespace UPLC2013 {
    internal class ProblemF {
        //private static void Main(string[] args) {
        //    new ProblemF().Solve(Console.In);
        //}

        private void Solve(TextReader reader) {
            while (true) {
                var n = int.Parse(reader.ReadLine());
                if (n == 0) {
                    return;
                }
                var answer = 0;
                while (n > 0) {
                    n = n / 5;
                    answer += n;
                }
                Console.WriteLine(answer);
            }
        }
    }
}