using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UPLC2013 {
    internal class ProblemG {
        private static void Main(string[] args) {
            new ProblemG().Solve(Console.In);
        }

        private void Solve(TextReader reader) {
            var lastns = reader.ReadLine().Split().Select(int.Parse).ToArray();
            while (true) {
                var str = reader.ReadLine();
                if (str == null) {
                    break;
                }
                var ns = str.Split().Select(int.Parse).ToList();
                var maxNs = new int[ns.Count];
                for (int i = 0; i < lastns.Length; i++) {
                    maxNs[i] = Math.Max(maxNs[i], ns[i] + lastns[i]);
                    maxNs[i+1] = Math.Max(maxNs[i+1], ns[i+1] + lastns[i]);
                }
                lastns = maxNs;
            }
            Console.WriteLine(lastns.Max());
        }
    }
}