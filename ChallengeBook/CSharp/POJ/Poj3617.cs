using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
