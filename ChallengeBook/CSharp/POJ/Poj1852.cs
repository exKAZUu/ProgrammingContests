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
using System.Collections.Generic;

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