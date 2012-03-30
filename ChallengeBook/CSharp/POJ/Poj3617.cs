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

using System.Linq;

namespace ChallengeBook.POJ {
	public class Poj3617 {
		public string Solve(string s) {
			var t = "";
			var rev = new string(s.Reverse().ToArray());
			int iStr = 0, iRev = 0;
			while (iStr + iRev < s.Length) {
				if (s.Substring(iStr).CompareTo(rev.Substring(iRev)) <= 0) {
					t += s[iStr++];
				} else {
					t += s[iRev++];
				}
			}
			return t;
		}
	}
}