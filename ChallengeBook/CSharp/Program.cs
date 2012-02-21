using System;
using ChallengeBook.Original;

namespace ChallengeBook {
	internal class Program {
		private static void Main(string[] args) {
			var permutation = new Permutation(4);
			foreach (var perm in permutation.GetPermutations()) {
				foreach (var p in perm) {
					Console.Write(p);
				}
				Console.WriteLine();
			}
		}
	}
}