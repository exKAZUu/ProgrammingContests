using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Using my library: https://github.com/exKAZUu/Paraiba

namespace GoogleCodeJam.GCJ2012.Round2
{
	public class ProblemD
	{
		//public static void Main(string[] args) {
		//    new ProblemD().Solve(Console.In);
		//}

		private void Solve(TextReader reader) {
			var nTestCases = int.Parse(reader.ReadLine().Trim());
			for (int i = 0; i < nTestCases; i++) {
				var values = reader.ReadLine().Split(' ').Select(int.Parse).ToList();

				Console.WriteLine((i + 1) + ": ");
			}
		}
	}
}
