using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.Original {
	public class Coin {
		public int Solve(int[] nCoins, int total) {
			var result = 0;
			// 1, 5, 10, 50, 100, 500
			var values = new[] { 1, 5, 10, 50, 100, 500 };
			for (int iCoins = values.Length - 1; iCoins >= 0; iCoins--) {
				var nUseCoin = Math.Min(total / values[iCoins], nCoins[iCoins]);
				result += nUseCoin;
				total -= nUseCoin * values[iCoins];
			}
			return result;
		}
	}
}
