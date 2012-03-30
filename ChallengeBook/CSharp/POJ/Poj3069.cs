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

using System.Collections.Generic;

namespace ChallengeBook.POJ {
	public class Poj3069 {
		public int Solve(int[] xs, int radius) {
			var result = 0;

			var xlist = new List<int>(xs);
			xlist.Sort();

			var i = 0;
			while (i < xlist.Count) {
				var left = xlist[i++];
				while (i < xlist.Count && xlist[i] <= left + radius) {
					i++;
				}

				left = xlist[i - 1];
				while (i < xlist.Count && xlist[i] <= left + radius) {
					i++;
				}

				result++;
			}
			return result;
		}
	}
}