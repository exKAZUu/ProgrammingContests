#region License

// Copyright (C) 2011-2012 Kazunori Sakamoto
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace AtCoder.AtCoder009 {
	internal class ProblemC {
		private static void Main(string[] args) {
			new ProblemC().Solve(Console.In);
		}

		private void Solve(TextReader input) {
			var nk = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var answer = BigInteger.One;
			BigInteger n = nk[0];
			BigInteger k = nk[1];
			answer *= Combination(n, n - k);
			answer *= Calculate(k);
			Console.WriteLine(answer % 1777777777);
		}

		private BigInteger Combination(BigInteger n, BigInteger m) {
			var r = BigInteger.One;
			for (var i = n - m + 1; i <= n; i++) {
				r *= i;
			}
			for (var i = 1; i <= m; i++) {
				r /= i;
			}
			return r;
		}

		private BigInteger Calculate(BigInteger n) {
			if (n == 1) {
				return 0;
			}
			if (n == 2) {
				return 1;
			}
			if (n == 3) {
				return 2;
			}
			BigInteger a = 1;
			BigInteger b = 2;
			for (BigInteger i = 3; i < n; i++) {
				BigInteger c = (a + b) * i;
				a = b;
				b = c;
			}
			return b;
		}
	}
}