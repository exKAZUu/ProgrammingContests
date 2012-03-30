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