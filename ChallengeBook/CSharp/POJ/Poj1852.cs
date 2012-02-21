using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.POJ {
	public class Poj1852 {
		public Tuple<int, int> Solve(int length, IEnumerable<int> positions) {
			var minTime = int.MaxValue;
			var maxTime = 0;

			foreach (var position in positions) {
				var min = Math.Min(position, length - position);
				var max = Math.Max(position, length - position);
				minTime = Math.Max(minTime, min);
				maxTime = Math.Max(maxTime, max);
			}

			return Tuple.Create(minTime, maxTime);
		}
	}
}
