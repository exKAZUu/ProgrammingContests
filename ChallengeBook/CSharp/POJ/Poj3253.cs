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
	public class Poj3253 {
		public int Solve(int[] lens) {
			var result = 0;

			var lenList = new List<int>(lens);
			lenList.Sort();
			for (int i = 1; i < lenList.Count; i++) {
				var newLen = lenList[i - 1] + lenList[i];
				result += newLen;
				var j = i + 1;
				for (; j < lenList.Count && lenList[j] < newLen; j++) {
					lenList[j - 1] = lenList[j];
				}
				lenList[j - 1] = newLen;
			}
			return result;
		}
	}
}