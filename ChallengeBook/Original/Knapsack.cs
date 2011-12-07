using System;

namespace ChallengeBook.Original {
	public class Knapsack {
		public int dfs(int iItems, int maxWeight, int[] weights, int[] values) {
			if (weights.Length == iItems) {
				return 0;
			}
			if (maxWeight < weights[iItems]) {
				return dfs(iItems + 1, maxWeight, weights, values);
			}
			return
					Math.Max(
							dfs(iItems + 1, maxWeight - weights[iItems], weights, values)
							+ values[iItems], dfs(iItems + 1, maxWeight, weights, values));
		}

		public int dp(
				int iItems, int maxWeight, int[] weights, int[] values, int[,] table) {
			if (table[iItems, maxWeight] >= 0) {
				return table[iItems, maxWeight];
			}
			var result = 0;
			if (weights.Length != iItems) {
				result = dfs(iItems + 1, maxWeight, weights, values);
				if (maxWeight >= weights[iItems]) {
					result = Math.Max(
							dfs(iItems + 1, maxWeight - weights[iItems], weights, values)
							+ values[iItems], result);
				}
			}
			table[iItems, maxWeight] = result;
			return result;
		}

		public int Solve(int maxWeight, int[] weights, int[] values) {
			return dfs(0, maxWeight, weights, values);
		}
	}
}