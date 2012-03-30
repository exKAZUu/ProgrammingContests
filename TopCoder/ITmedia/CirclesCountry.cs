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

namespace TopCoder.ITmedia {
	public class CirclesCountry {
		public int leastBorders(
				int[] X, int[] Y, int[] R, int x1, int y1, int x2, int y2) {
			var count = 0;
			for (int i = 0; i < X.Length; i++) {
				if (IsInside(X[i], Y[i], R[i], x1, y1) ^ IsInside(X[i], Y[i], R[i], x2, y2)) {
					count++;
				}
			}
			return count;
		}

		public bool IsInside(int x, int y, int r, int px, int py) {
			return (x - px) * (x - px) + (y - py) * (y - py) <= r * r;
		}
	}
}