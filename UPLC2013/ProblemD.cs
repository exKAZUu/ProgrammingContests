using System;
using System.IO;
using System.Linq;

namespace UPLC2013 {
    internal class ProblemD {
        //private static void Main(string[] args) {
        //    new ProblemD().Solve(Console.In);
        //}

        private void Solve(TextReader reader) {
            var answer = 0;
            while (true) {
                var str = reader.ReadLine();
                if (str == null) {
                    Console.WriteLine(answer);
                    return;
                }
                for (var ch = 'a'; ch <= 'z'; ch++) {
                    str = str.Replace(ch, ' ');
                }
                for (var ch = 'A'; ch <= 'Z'; ch++) {
                    str = str.Replace(ch, ' ');
                }
                var strs = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                answer += strs.Select(int.Parse).Sum();
            }
        }
    }
}