using System;
using System.IO;
using System.Linq;

namespace UPLC2013 {
    internal class ProblemA {
        //private static void Main(string[] args) {
        //    new ProblemA().Solve(Console.In);
        //}

        private void Solve(TextReader reader) {
            var nTestCases = int.Parse(reader.ReadLine().Trim());
            for (int iTestCases = 0; iTestCases < nTestCases; iTestCases++) {
                var xys = reader.ReadLine().Split(' ').Select(s => double.Parse(s.Trim())).ToList();
                var i = 0;
                var x1 = xys[i++];
                var y1 = xys[i++];
                var x2 = xys[i++];
                var y2 = xys[i++];
                var x3 = xys[i++];
                var y3 = xys[i++];
                var x4 = xys[i++];
                var y4 = xys[i++];
                var isParallel = Math.Abs(((x2 - x1) * (y4 - y3) - (x4 - x3) * (y2 - y1))) <= 0.000000000000001;
                Console.WriteLine(isParallel ? "YES" : "NO");
            }
        }
    }
}