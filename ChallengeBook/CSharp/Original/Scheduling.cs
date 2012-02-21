using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.Original {
	public class Scheduling {
		public int Solve(int[] starts, int[] ends) {
			var result = 0;
			var time = 0;
			var startAndEnds = new List<Tuple<int, int>>();
			for (int i = 0; i < starts.Length; i++) {
				startAndEnds.Add(Tuple.Create(starts[i], ends[i]));
			}
			startAndEnds.Sort((t1, t2) => t1.Item2 - t2.Item2);
			foreach (var startAndEnd in startAndEnds) {
				if (time < startAndEnd.Item1) {
					time = startAndEnd.Item2;
					result++;
				}
			}
			return result;
		}
	}
}
